using places;


class Program {

    static void Main(string[] arg) {

        var place = new Place("Stavern", "Larvik", "Vestfold");

        place.showPlace();

        Place place2 = new Place("Gressvik", "Fredrikstad", "Østfold");

        place2.showPlace();
    }
}
