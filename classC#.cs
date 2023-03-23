using Person;
/*
 * 沒加using
Person.Head head1 = new Head();
*/
Head head1 = new Head();

head1.ears = 2;
head1.eyes = 2;
head1.nose = 1;
head1.moouth = 1;

System.Console.WriteLine(head1.ears);
