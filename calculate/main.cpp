#include <iostream>
#include <fstream>
#include <string>
#include <queue>

using namespace std;

// رئوس
int is2year(string g) {
    if(g.substr(0,4)=="2021" || g.substr(0,4)=="2020")
        return 1;
    if(g.substr(0,4)=="2019" && g.substr(5,2)!="01")
        return 1;
    if(g.substr(0,4)=="2019" && g.substr(8,2)>="19")
        return 1;
    return 0;
}
class ssnset {
public:
    string data[10000];
    int job[10000];
    int isown[10000]={0};
    int size;
    ssnset() {
        fstream fs("people.csv");
        string line;
        getline(fs,line);
        int row=0;
        size=0;
        row = 2;
        while(getline(fs,line)) {
            int ssnpos=0;
            string g="",gg="";
            for(int i=0;i<line.size();i++) {
                if(line[i]==',')
                    ssnpos++;
                if(ssnpos==row && line[i]!='"' && line[i]!=',')
                    g = g+line[i];
                if(ssnpos==5 && line[i]!='"' && line[i]!=',')
                    gg = gg+line[i];

            }
            data[size]=g;
            if(gg=="گمرک" || gg=="سازمان بنادر")
                job[size]=1;
            else if(gg=="قاچاقچی")
                job[size]=0;
            else
                job[size]=3;
            //job[size]=gg;
            size++;
        }
        fs.close();
        quickSort(0,size-1);

        //=====================================================

        fstream f("ownerships.csv");
        getline(f,line);
        while(getline(f,line)) {
            int r=0;
            string g1="",g2="";
            for(int i=0;i<line.size();i++) {
                if(line[i]==',')
                    r++;
                if(r>1) break;
                if(r==0 && line[i]!='"' && line[i]!=',')
                    g1=g1+line[i];
                if(r==3 && line[i]!='"' && line[i]!=',')
                    g2=g2+line[i];
            }
            if(1)
                isown[index(g1)]=1;
        }
        f.close();
    }
    void test() {
        for(int i=0;i<size;i++)
            cout << i << "-  " << data[i] << " "<< job[i]<<endl;
    }
    int partition ( int low, int high)
    {
        string pivot = data[high]; // pivot
        int i = (low - 1); // Index of smaller element

        for (int j = low; j <= high - 1; j++)
        {
            // If current element is smaller than the pivot
            if (data[j] < pivot)
            {
                i++; // increment index of smaller element
                swap(data[i], data[j]);
                swap(job[i],job[j]);
            }
        }
        swap(data[i + 1], data[high]);
        swap(job[i+1],job[high]);
        return (i + 1);
    }
    void quickSort( int low, int high)
    {
        if (low < high)
        {
            /* pi is partitioning index, data[p] is now
            at right place */
            int pi = partition( low, high);

            // Separately sort elements before
            // partition and after partition
            quickSort( low, pi - 1);
            quickSort( pi + 1, high);
        }
    }
    int index(int first,int last,string x) {
        if(last<first) return -1;
        int mid=(first+last)/2;
        if(data[mid]==x)
            return mid;
        if(data[mid]>x)
            return index(first,mid-1,x);
        else
            return index(mid+1,last,x);
    }
    int index(string x) {
        return index(0,size-1,x);
    }
};
struct phone {
    string ssn;
    string number;
};
class phoneset {
public:
    int size;
    phone data[10000];
    phoneset() {
        fstream fs("phones.csv");
        string line;
        getline(fs,line);
        size=0;

        while(getline(fs,line)) {
            int r=0;
            string g1="",g2="";
            for(int i=0;i<line.size();i++) {
                if(line[i]==',')
                    r++;
                if(r>1) break;
                if(r==0 && line[i]!='"' && line[i]!=',')
                    g1=g1+line[i];
                if(r==1 && line[i]!='"' && line[i]!=',')
                    g2=g2+line[i];
            }
            data[size].ssn=g1;
            data[size].number=g2;
            size++;
        }
        fs.close();
        quickSort(0,size-1);
    }
    int partition ( int low, int high)
    {
        phone pivot = data[high]; // pivot
        int i = (low - 1); // Index of smaller element

        for (int j = low; j <= high - 1; j++)
        {
            // If current element is smaller than the pivot
            if (data[j].number < pivot.number)
            {
                i++; // increment index of smaller element
                swap(data[i], data[j]);
            }
        }
        swap(data[i + 1], data[high]);
        return (i + 1);
    }
    void quickSort( int low, int high)
    {
        if (low < high)
        {
            /* pi is partitioning index, data[p] is now
            at right place */
            int pi = partition( low, high);

            // Separately sort elements before
            // partition and after partition
            quickSort( low, pi - 1);
            quickSort( pi + 1, high);
        }
    }
    void test() {
        for(int i=0;i<size;i++)
            cout << i << "-  " << data[i].ssn << "_" << data[i].number << endl;
    }
    string find(int first,int last,string x) {
        if(last<first)
            return "";
        int mid = (first+last)/2;
        if(data[mid].number==x)
            return data[mid].ssn;
        if(data[mid].number<x)
            return find(mid+1,last,x);
        if(data[mid].number>x)
            return find(first,mid-1,x);
        return "";
    }
    string findssn(string x) {
        return find(0,size-1,x);
    }
};
struct account {
    string ssn;
    string id;
};
class accountset {
public:
    int size;
    account data[10000];
    accountset() {
        fstream fs("accounts.csv");
        string line;
        getline(fs,line);
        size=0;

        while(getline(fs,line)) {
            int r=0;
            string g1="",g2="";
            for(int i=0;i<line.size();i++) {
                if(line[i]==',')
                    r++;
                if(r==0 && line[i]!='"' && line[i]!=',')
                    g1=g1+line[i];
                if(r==3 && line[i]!='"' && line[i]!=',')
                    g2=g2+line[i];
            }
            data[size].ssn=g1;
            data[size].id=g2;
            size++;
        }
        fs.close();
        quickSort(0,size-1);
    }
    int partition ( int low, int high)
    {
        account pivot = data[high]; // pivot
        int i = (low - 1); // Index of smaller element

        for (int j = low; j <= high - 1; j++)
        {
            // If current element is smaller than the pivot
            if (data[j].id < pivot.id)
            {
                i++; // increment index of smaller element
                swap(data[i], data[j]);
            }
        }
        swap(data[i + 1], data[high]);
        return (i + 1);
    }
    void quickSort( int low, int high)
    {
        if (low < high)
        {
            /* pi is partitioning index, data[p] is now
            at right place */
            int pi = partition( low, high);

            // Separately sort elements before
            // partition and after partition
            quickSort( low, pi - 1);
            quickSort( pi + 1, high);
        }
    }
    void test() {
        for(int i=0;i<size;i++)
            cout << i << "-  " << data[i].ssn << "_" << data[i].id << endl;
    }
    string find(int first,int last,string x) {
        if(last<first)
            return "";
        int mid = (first+last)/2;
        if(data[mid].id==x)
            return data[mid].ssn;
        if(data[mid].id<x)
            return find(mid+1,last,x);
        if(data[mid].id>x)
            return find(first,mid-1,x);
        return "";
    }
    string findssn(string x) {
        return find(0,size-1,x);
    }
};
struct home {
    string ssn;
    string postalcode;
};
class homeset {
public:
    int size;
    home data[10000];
    homeset() {
        fstream fs("homes.csv");
        string line;
        getline(fs,line);
        size=0;

        while(getline(fs,line)) {
            int r=0;
            string g1="",g2="";
            for(int i=0;i<line.size();i++) {
                if(line[i]==',')
                    r++;
                if(r>2) break;
                if(r==0 && line[i]!='"' && line[i]!=',')
                    g1=g1+line[i];
                if(r==2 && line[i]!='"' && line[i]!=',')
                    g2=g2+line[i];
            }
            data[size].ssn=g1;
            data[size].postalcode=g2;
            size++;
        }
        fs.close();
        quickSort(0,size-1);
    }
    int partition ( int low, int high)
    {
        home pivot = data[high]; // pivot
        int i = (low - 1); // Index of smaller element

        for (int j = low; j <= high - 1; j++)
        {
            // If current element is smaller than the pivot
            if (data[j].postalcode < pivot.postalcode)
            {
                i++; // increment index of smaller element
                swap(data[i], data[j]);
            }
        }
        swap(data[i + 1], data[high]);
        return (i + 1);
    }
    void quickSort( int low, int high)
    {
        if (low < high)
        {
            /* pi is partitioning index, data[p] is now
            at right place */
            int pi = partition( low, high);

            // Separately sort elements before
            // partition and after partition
            quickSort( low, pi - 1);
            quickSort( pi + 1, high);
        }
    }
    void test() {
        for(int i=0;i<size;i++)
            cout << i << "-  " << data[i].ssn << "_" << data[i].postalcode << endl;
    }
    string find(int first,int last,string x) {
        if(last<first)
            return "";
        int mid = (first+last)/2;
        if(data[mid].postalcode==x)
            return data[mid].ssn;
        if(data[mid].postalcode<x)
            return find(mid+1,last,x);
        if(data[mid].postalcode>x)
            return find(first,mid-1,x);
        return "";
    }
    string findssn(string x) {
        return find(0,size-1,x);
    }

};
struct car {
    string ssn;
    string plate;
};
class carset {
public:
    int size;
    car data[10000];
    carset() {
        fstream fs("cars.csv");
        string line;
        getline(fs,line);
        size=0;

        while(getline(fs,line)) {
            int r=0;
            string g1="",g2="";
            for(int i=0;i<line.size();i++) {
                if(line[i]==',')
                    r++;
                if(r>1) break;
                if(r==0 && line[i]!='"' && line[i]!=',')
                    g1=g1+line[i];
                if(r==1 && line[i]!='"' && line[i]!=',')
                    g2=g2+line[i];
            }
            data[size].ssn=g2;
            data[size].plate=g1;
            size++;
        }
        fs.close();
        quickSort(0,size-1);
    }
    int partition ( int low, int high)
    {
        car pivot = data[high]; // pivot
        int i = (low - 1); // Index of smaller element

        for (int j = low; j <= high - 1; j++)
        {
            // If current element is smaller than the pivot
            if (data[j].plate < pivot.plate)
            {
                i++; // increment index of smaller element
                swap(data[i], data[j]);
            }
        }
        swap(data[i + 1], data[high]);
        return (i + 1);
    }
    void quickSort( int low, int high)
    {
        if (low < high)
        {
            /* pi is partitioning index, data[p] is now
            at right place */
            int pi = partition( low, high);

            // Separately sort elements before
            // partition and after partition
            quickSort( low, pi - 1);
            quickSort( pi + 1, high);
        }
    }
    void test() {
        for(int i=0;i<size;i++)
            cout << i << "-  " << data[i].ssn << "_" << data[i].plate << endl;
    }
    string find(int first,int last,string x) {
        if(last<first)
            return "";
        int mid = (first+last/2);
        if(data[mid].plate==x)
            return data[mid].ssn;
        if(data[mid].plate<x)
            return find(mid+1,last,x);
        if(data[mid].plate>x)
            return find(first,mid-1,x);
        return "";
    }
    string findssn(string x) {
        return find(0,size-1,x);
    }
};




class faze1 {
public:
    int ans[10000]={0};
    int size;
    faze1()  {

    ssnset s;
    size=s.size;
    fstream ff("relationships.csv");
    string line;
    getline(ff,line);
    while(getline(ff,line)) {
        int r=0;
        string g1="",g2="";
        for(int i=0;i<line.size();i++) {
            if(line[i]==',')
                r++;
            if(r>1) break;
            if(r==0 && line[i]!='"' && line[i]!=',')
                g1=g1+line[i];
            if(r==1 && line[i]!='"' && line[i]!=',')
                g2=g2+line[i];
        }
        if(s.job[s.index(g1)]==1) {
            if(s.isown[s.index(g2)] || s.isown[s.index(g1)])
                ans[s.index(g1)]=1;
        }
    }
    for(int i=0;i<size;i++) {
        if(s.job[i]==1 && s.isown[i]==1)
            ans[i]=1;
    }
    ff.close();
    fstream f("f2.txt");
    for(int i=0;i<size;i++) {
        if(ans[i])
            f << s.data[i] << endl;
    }
    f.close();
    }
    void test()
    {
        for(int i=0;i<size;i++) {
            cout <<ans[i];
        }
        cout << endl;
    }
};
faze1 f1;
class faze2 {
public:
    int ans[10000]={0};
    int lastans[10000];
    queue<int> graph[10000];
    int size;

    faze2() {
        ssnset s;
        accountset a;


        size=s.size;
        for(int i=0;i<size;i++)
            lastans[i]=f1.ans[i];
        fstream fs("transactions.csv");
        string line;
        getline(fs,line);
        while(getline(fs,line)) {
            int r=0;
            string g1="",g2="";
            for(int i=0;i<line.size();i++) {
                if(line[i]==',')
                    r++;
                if(r>1) break;
                if(r==0 && line[i]!='"' && line[i]!=',')
                    g1=g1+line[i];
                if(r==1 && line[i]!='"' && line[i]!=',')
                    g2=g2+line[i];
            }
            graph[s.index(a.findssn(g1))].push(s.index(a.findssn(g2)));
        }
        fs.close();
        //============================================================ áíÓÊ ãÌÇæÑÊ ÓÇÎÊå ÔÏ
        for(int i=0;i<size;i++) {
            if(s.job[i]==0) {
                travers(i,0);
            }
        }
        fstream f("f3.txt");
        for(int i=0;i<size;i++) {
            if(ans[i])
                f << s.data[i] << endl;
        }
        f.close();


    }

    void travers(int ind, int time) {
        if(time>=5)
            return;
        if(lastans[ind])
            ans[ind]=1;

        for(int i=0;i<graph[ind].size();i++) {
            int child = graph[ind].front();
            graph[ind].pop();
            graph[ind].push(child);
            travers(child,time+1);
        }
    }
    void test()
    {
        for(int i=0;i<size;i++) {
            cout <<ans[i];
        }
        cout << endl;
    }
};
faze2 f2;
class faze3 {
public:
    int ans[10000]={0};
    int size;
    faze3() {
        ssnset s;
        phoneset p;
        size=s.size;
        fstream fs("calls.csv");
        string line;
        getline(fs,line);
        while(getline(fs,line)) {
            int r=0;
            string g1="",g2="";
            for(int i=0;i<line.size();i++) {
                if(line[i]==',')
                    r++;
                if(r>1) break;
                if(r==0 && line[i]!='"' && line[i]!=',')
                    g1=g1+line[i];
                if(r==1 && line[i]!='"' && line[i]!=',')
                    g2=g2+line[i];
            }
            if(f2.ans[s.index(p.findssn(g1))]==1 && s.job[s.index(p.findssn(g2))]==0)
               ans[s.index(p.findssn(g1))]=1;
            if(f2.ans[s.index(p.findssn(g2))]==1 && s.job[s.index(p.findssn(g1))]==0)
               ans[s.index(p.findssn(g2))]=1;
        }
        fs.close();

        fstream f("f4.txt");
        for(int i=0;i<size;i++) {
            if(ans[i])
                f << s.data[i] << endl;
        }
        f.close();
    }
    void test()
    {
        for(int i=0;i<size;i++) {
            cout <<ans[i];
        }
    }
};
faze3 f3;
int main() {
    f1.test();
    f2.test();
    f3.test();
}
