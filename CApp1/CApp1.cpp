#include <stdio.h>

void f1() {	printf("Function F1\n"); }
void f2() { printf("Function F2\n"); }
void f3() { printf("Function F3\n"); }

int main()
{
	void* func[3] = { f1, f2, f3 };
	for(int i = 0;i<3;i++)((void(*)(void))(func[i]))()   ; //((void(*)(void))(func))()
	//[3] = { f1, f2, f3 };
}
