

using TaskMethodOverLoading;
using static TaskMethodOverLoading.AreaExmp;

AreaExmp ae = new AreaExmp();
ae.Area(6);
ae.Area(5.6, 6);
ae.Area(5, 6);

PerimeterExmp pe = new PerimeterExmp();
pe.Perimeter(5);
pe.Perimeter(5, 6);
pe.Perimeter(5, 6, 7);