ArtifactCatalog catalog = new ArtifactCatalog();



catalog.Add(new Artifact("Echo Stone", "Moon"));
catalog.Add(new Artifact("Glass Seed", "Mars"));





catalog.PrintAll();

Artifact? found = catalog.FindByName("");

Artifact? found2 = catalog.FindByName("Glass Seed");



Console.WriteLine(found is null ? "Not found" : $"Found: {found.Name}");

Console.WriteLine(found2 is null ? "Not found" : $"Found: {found2.Name}");

