using Observer;

var ingaBlog = new BlogPost("IngaBlog");
var joraCardanBlog = new BlogPost("JoraCardanBlog");

var Valera = new Subscriber("Valera");
var Tania = new Subscriber("Tania");
var Masha = new Subscriber("Masha");

ingaBlog.Enrole(Valera);
ingaBlog.Enrole(Tania);
ingaBlog.Enrole(Masha);
joraCardanBlog.Enrole(Valera);

ingaBlog.Notify("Am venit de la mare!!!");
joraCardanBlog.Notify("Vind discuri pentru Dacia");
ingaBlog.Notify("De la Odesa )))");

ingaBlog.ShowLogs();
Console.WriteLine();
joraCardanBlog.ShowLogs();
Console.WriteLine();
Valera.ShowLogs();
Console.WriteLine();
Tania.ShowLogs();
Console.WriteLine();
Masha.ShowLogs();
Console.WriteLine();
