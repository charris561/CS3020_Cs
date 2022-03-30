using EventsMyDude;

Kitchen theKitchen = new Kitchen();
Chef boyardee = new Chef();
Chef gordon = new Chef();

boyardee.name = "Boy-ar-dee";
gordon.name = "Idiot Sandwich";

//theKitchen.OrderReceived += boyardee.OnOrderReceived;
theKitchen.OrderReceived += gordon.OnOrderReceived;
theKitchen.OrderReceived += gordon.OnOrderReceived;

theKitchen.OrderHasBeenPlaced();

theKitchen.OrderReceived -= gordon.OnOrderReceived;

theKitchen.OrderHasBeenPlaced();