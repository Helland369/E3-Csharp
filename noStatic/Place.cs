namespace places {


    class Place
    {

        public string placeName { get; private set; }
        public string municipality { get; private set; }
        public string region { get; private set; }

        public Place(string placeName, string municipality, string region) {

            this.placeName = placeName;
            this.municipality = municipality;
            this.region = region;
        }
        
        public void showPlace() {

            int labelWidth = 8;
            sepparator(8);
            showNameAndValue("Navn", labelWidth, placeName);
            showNameAndValue("Kommune", labelWidth, municipality);
            showNameAndValue("Fylke", labelWidth, region);
            sepparator(8);

        }

        private void showNameAndValue(string label, int width, string fValue) {

            width -= label.Length;
            Console.WriteLine(" " + label + ":" + string.Empty.PadLeft(width, ' ') + fValue);
        }

        private void sepparator(int width) {

            width += 16;
            Console.WriteLine(string.Empty.PadLeft(width, '#'));
        }

    }
    
}
