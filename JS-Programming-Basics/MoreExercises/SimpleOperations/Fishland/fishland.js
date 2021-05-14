function fishland(input) {
   let skumriqPrice = Number(input[0]);
   let cacaPrice = Number(input[1]);
   let palamudWeight = Number(input[2]);
   let safridWeight = Number(input[3]);
   let midiWeight = Number(input[4]);

   let palamudPrice = skumriqPrice + (skumriqPrice * 0.6);
   let safridPrice = cacaPrice + (cacaPrice * 0.8);
   let midiPrice = 7.50;

   let totalPricePalamud = palamudWeight * palamudPrice;
   let totalSafridPrice = safridWeight * safridPrice;
   let totalMidiPrice = midiWeight * midiPrice;

   let totalPrice = (totalPricePalamud + totalSafridPrice + totalMidiPrice);
   console.log(totalPrice.toFixed(2));

}
fishland(["6.90","4.20","1.5","2.5","1"]);