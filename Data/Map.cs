namespace TestPac.Data
{
    class Map
    {
        private const int EILUTES = 11;
        private const int STULPELIAI = 20;
        public int Eilutes { get; set; }
        public int Stulpeliai { get; set; }

        //public char[,] ZaidimoTaskiukai { get; set; } = new char[EILUTES, STULPELIAI];
        //public char[,] ZaidimoLenta { get; set; } = new char[EILUTES, STULPELIAI];
        public char[,] ZaidimoLenta { get; set; } = new char[EILUTES, STULPELIAI]
        {
            {GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena},
            {GameObjects.Siena, GameObjects.StebuklingasZirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.StebuklingasZirniukas, GameObjects.Siena},
            {GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena},
            {GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena},
            {GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena, GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena, GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena},
            {GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena},
            {GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena, GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena, GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena},
            {GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena},
            {GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Siena},
            {GameObjects.Siena, GameObjects.StebuklingasZirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.Zirniukas, GameObjects.StebuklingasZirniukas, GameObjects.Siena},
            {GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena, GameObjects.Siena}
        };

        public Map()
        {
            Eilutes = EILUTES;
            Stulpeliai = STULPELIAI;
        }
    }
}
