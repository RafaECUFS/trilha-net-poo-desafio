using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new Iphone("7998450000", "xlr8","1sc65",64);
Nokia nokia= new Nokia("7988523301","tijolao","phonk13",32);
nokia.InstalarAplicativo("Fruit Ninja");
iphone.InstalarAplicativo("Facetune");
nokia.Ligar();
iphone.ReceberLigacao();