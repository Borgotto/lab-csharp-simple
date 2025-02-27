namespace Properties
{
    using System;

    /// <summary>
    /// The class models a card.
    /// </summary>
    public class Card
    {
        private readonly string seed;
        private readonly string name;
        private readonly int ordinal;

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="name">the name of the card.</param>
        /// <param name="seed">the seed of the card.</param>
        /// <param name="ordinal">the ordinal number of the card.</param>
        public Card(string name, string seed, int ordinal)
        {
            this.name = name;
            this.ordinal = ordinal;
            this.seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="tuple">the informations about the card as a tuple.</param>
        internal Card(Tuple<string, string, int> tuple) : this(tuple.Item1, tuple.Item2, tuple.Item3)
        {
        }

        // TODO improve
        public string Seed => this.seed;

        // TODO improve
        public string Name => this.name;

        // TODO improve
        public int Ordinal => this.ordinal;
        

        /// <inheritdoc cref="object.ToString"/>
        public override string ToString()
        {
            // TODO understand string interpolation
            return $"{this.GetType().Name}(Name={this.Name}, Seed={this.Seed}, Ordinal={this.Ordinal})";
        }

        // TODO generate Equals(object obj)
        public bool Equals(Card other)
        {
            return string.Equals(this.seed, other.seed)
                   && string.Equals(this.name, other.name)
                   && this.ordinal == other.ordinal;
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;

            if (obj.GetType() != this.GetType()) return false;

            if (this == obj) return true;          

            return this.Equals(obj as Card);
        }


        // TODO generate GetHashCode()
        public override int GetHashCode()
        {
            return HashCode.Combine(this.seed, this.name, this.ordinal);
        }
    }
}
