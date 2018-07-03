using System;

class Test {
    public int value;

    public Test DeepCopy() {
        Test newTest = new Test();

        newTest.value = this.value;
        return newTest;
    }
}

public class Class1
{
	static void Main(string[] args) {
        int a = 0, b = 0;

        b = a;
        a = 333;
        b = 777;
        //Console.WriteLine(a);
        //------------------
        Test testA = new Test();
        Test testB = new Test();
        testB = testA;

        testA.value = 333;
        testB.value = 777;

        Console.WriteLine(testA.value);

        Test tc = new Test();
        Test td = new Test();

        td = tc.DeepCopy();
        tc.value = 333;
        td.value = 777;

        Console.WriteLine(tc.value);
        Console.WriteLine(td.value);
    }
}