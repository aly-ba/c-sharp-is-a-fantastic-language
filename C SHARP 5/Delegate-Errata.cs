{
 class Person 
 {
	private string _name;
	
	//je crée un nouveu field de type mon delegate ci -dessous
	public event NameChangedDelegate  NameChanged 
	//public NameChangedDelegate  NameChanged//old 
	
	public string Name 
	{
		get{
	          return _name;
		   }
		   
		  set {
		   if(_name != value ) 
		   {
				var oldValue = this._name;
				    _name = value;
				if( NameChanded !=nll ) 
				{
				NameChanged(oldValue, value);
				}
			   
		   }
		  }
	}
 }
 //class Delegate
 {
 
 //je crée un delegate classiqiue
 public delegete void NamedChanged(srting value, string new value);
 }
 
  class Main {
  //j'instancie mon delegate j'appele un parametre d'observation
  
  static void Main(string args[] ) {
  
  book.NameChanged = new NamedChandedDelegate(OnNameChanged);
  // ou bien l'appeler par le biais d'un multi cast delegate
  book.NameChanged +=OnNameChaned;
  book.NameChanged +=OnNameChaned;
  book.NameChanged +=OnNameChaned2;
    book.NameChanged -=OnNameChaned2;
  //mais refaire ici 
   book.NameChanged = new NamedChandedDelegate(OnNameChanged);
   //tue les processus des ses derniers(les trois autres).
  book.Name =" Bon les delegates voila voila ";
  
  private static void OnNameChanded(string oldvalue, string newValue) 
  {
	//code here
	Console.WriteLine("Name chaned rom [0} to {1}", oldValue; newValue);
  }
  
  }
  
  }
}




///Claqss
 class NameChandedEventsArgs : EventsArgs
    {
	public string Olvalue {get; set; }
	public sirtng NewValue{get; set; }
	
	}
	
	
	
	//appliquer dans delegate 
	public delegate void NamedChanedDelegate(
	object sender, NameChanedEventArgs args);
	
	//NameChanged  avec deletate autrement dans Book 
	NameChangedEventARgs args = new NameChanedEventsArgs();
	args.OldValue = Oldvalue;
	args.Newvlue = vlaue);
	NameChanged(this, args);
	
	// dans main
	public static void OnNameChnaed2(object sender, NameChanedEventArgs args)
	{
	       Console.WriteLine("*****");
    }
	