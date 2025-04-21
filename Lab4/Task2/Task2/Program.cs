using Task2.Mediator;

var runways = new List<Runway> { new Runway(), new Runway() };
var commandCentre = new CommandCentre(runways);

var aircraft1 = new Aircraft("Boeing 678", commandCentre);
var aircraft2 = new Aircraft("Aircraft 432", commandCentre);

aircraft1.Land();
aircraft2.Land(); 

aircraft1.TakeOff();
aircraft2.Land();