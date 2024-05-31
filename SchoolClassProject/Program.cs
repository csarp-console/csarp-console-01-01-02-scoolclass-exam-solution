using SchoolClassProject;

SchoolClass a9 = new SchoolClass(9, "a", 7000,26);
Console.WriteLine("5. feladat");
Console.WriteLine(a9);
SchoolClass b9 = new SchoolClass(9, "b", 6000,28);
Console.WriteLine(b9);

Console.WriteLine("7. feladat");
int difference=Math.Abs(a9.ClassFee-b9.ClassFee);
if (a9.ClassFee>b9.ClassFee)
    Console.WriteLine($"{a9.ShortClassName} osztály diákjai havonta {difference} Ft többet fizetnek osztálypénzbe mint {b9.ShortClassName}.");
else if (b9.ClassFee > a9.ClassFee)
    Console.WriteLine($"{b9.ShortClassName} osztály diákjai havonta {difference} Ft többet fizetnek osztálypénzbe mint {a9.ShortClassName}.");
else
    Console.WriteLine($"{a9.ShortClassName} és {b9.ShortClassName}  osztály tanulói ugyan annyit fizetnek osztálypénzbe havonta.");


SchoolClass c9 = new SchoolClass(9, "c", 9000, 28);
SchoolClass d9 = new SchoolClass(9, "d", 6000, 28);

SchoolClassRepo schoolClassRepo = new SchoolClassRepo();
schoolClassRepo.Add(a9);
schoolClassRepo.Add(b9);
schoolClassRepo.Add(c9);
schoolClassRepo.Add(d9);

Console.WriteLine("12. feladat");
Console.WriteLine($"A {schoolClassRepo.MostPaidSchoolClass()} -ban fizetik a legnagyobb osztálypénzt.");

schoolClassRepo.FeePerSchoolClass();