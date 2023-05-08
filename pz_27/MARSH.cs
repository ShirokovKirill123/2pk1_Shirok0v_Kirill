namespace pz_27
{
        struct MARSH    //Структура
        {
            public string BEGST;
            public string TERM;
            public int NUMER;
            public override string ToString()
            {
                return (string.Format(@"
                                    Начальный пункт назначения: {0}
                                    Конечный пункт назначения: {1}
                                    Номер маршрута: {2}", BEGST, TERM, NUMER));
            }
        }
}