namespace MultiForms {
    internal class Fruit {

        public readonly int Id;
        public readonly string Name;
        public readonly decimal Egysegar;
        public readonly int Mennyiseg;

        public Fruit(int id, string name, decimal egysegar, int mennyiseg) {
            Id = id;
            Name = name;
            Egysegar = egysegar;
            Mennyiseg = mennyiseg;
        }

        public override string ToString() {
            return Name;
        }
    }
}
