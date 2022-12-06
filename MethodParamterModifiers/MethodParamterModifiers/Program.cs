

using MethodParamterModifiers;

ParamaterModifiers p = new();
p.Add(2, 3);
p.Add1(4, 5);
int add = 0,sub =0;
p.Add2( 5, 6, ref add,ref sub);
p.Add3(6, 7, out add, out sub);
