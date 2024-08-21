using Domain;

Cachorro objMeuCachorro = new Cachorro("Rex", "cachorro", "latido", "noite", "ração");
Console.WriteLine();

Console.WriteLine(objMeuCachorro.Mover(objMeuCachorro.Especie));
Console.WriteLine();

Console.WriteLine(objMeuCachorro.FazerSom(objMeuCachorro.SomEmite));
Console.WriteLine();

Console.WriteLine(objMeuCachorro.Dormir(objMeuCachorro.PeriodoDoDia, objMeuCachorro.Nome));
Console.WriteLine();

Console.WriteLine(objMeuCachorro.AlimentarAnimal(objMeuCachorro.Alimentacao, objMeuCachorro.Nome));




