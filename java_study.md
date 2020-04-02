# java_study

```java
int 
float
System.out.println(Math.PI);

// instance app.java
import java.io.PrintWriter;
public static void main(string[] args) throws IOException{
    printwriter p1 = new printetwriter("result1.txt");
// package 가wㅕ와야함
}
/* 
	인스턴스를 사용하는 이유: 같은 맥락의 작업을 사용하기위해 
*/
// inheritance 상속 Object > method > 

소비자 -> 판매자 -> 국세청
    expense 30% cost by seller => income  동업자 5:3:2

myapp project

AccountingApp
        
public class AccountingApp {
    public static void main(String[] args){
        double valueOfSupply = 12345.0;
		double vatRate = 0.1;
        double expenseRate = 0.3;
        double vat = valueOfSupply * vatRate;
        double total = valueOfSUpply + vat;
        double expense = valueOfSupply *expenseRate;
        double income = valueOfSupply - expense;
        double dividend1 = income*0.5;
        double dividend2 = income*0.3;
        double dividend3 = income*0.2;
        
        System.out.println("Value of supply : " + valueOfSypply);
        System.out.println("VAT : " + (valueOfSypply*vatRate) );
        System.out.println("Total : " + (valueOfSypply + valueOfSypply*vatRate) );
        System.out.println("Expense : " + (valueOfSypply*expenseRate) );
        System.out.println("Income : " + (valueOfSypply - valueOfSypply*expenseRate) );
        System.out.println("Dividend 1 : " + (valueOfSypply - valueOfSypply*0.5) );
        System.out.println("Dividend 2 : " + (valueOfSypply - valueOfSypply*expenseRate) );
        System.out.println("Dividend 3 : " + (valueOfSypply - valueOfSypply*0.2) );
    }
}

double value = Double.parseDouble(args[0])

// 제어문 조건문
if (value > 1000.0){
    ~~~;
} else {
    ~~~;
}
// 배열  args 앞에 배열형태 느낌.
double [] dividendRates = new double[3]; // 크기 3인 배열선언
// 반복문  배열.length = 배열의 크기
while() {
    ~~~;
}
// 메소드 method 서로 연관된 코드를 grouping해놓은거 
public static double getVAT(double valueOfSupply, double vatRate) {
    return valueOfSupply * vatRate;
}
// scope main 밖에서 선언
// class 구조결정 
Class Accounting{
    marsa
    amam
}
Accounting.marsa();
Accounting.amam();
//이런식으로 사용가능함.
Accounting a1 = new Accounting();
a1.valueOfSupply = 1;
a1.vatrate = 2;

Accounting a2 = new Accounting();
a2.valueOfSupply = 2;
a2. vatrate =3;
// class 복제안해도됨. a1, a2 ==> instance
// procedural programming






```























