notes:
Class Program 
{
static void GiveBookName( ref GradeBook book ) {
	book = new Gradebook();
	book.Name = "The new GradeBook";
}

static void IncrementNumber(int number) {
  //code Ici
}

static void Main(string []  args ) {
	Gradebook g1 = new GradeBook;
	Gradebook g2 = g1;
	
    GiveBookName( ref g2 );
	Console.Writeline(g2.Name);
	//Affiche  The new GradeBook"
}

