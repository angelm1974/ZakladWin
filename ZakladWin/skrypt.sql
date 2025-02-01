CREATE TABLE IF NOT EXISTS [klient] (
  [Id] INTEGER NOT NULL
, [imie] TEXT NOT NULL
, [nazwisko] TEXT NOT NULL
, [telefon] TEXT NOT NULL
,[deleted] INTEGER DEFAULT (0) NULL
, CONSTRAINT [PK_klient] PRIMARY KEY ([Id])
);

CREATE TABLE IF NOT EXISTS [pracownik] (
  [Id] INTEGER NOT NULL
, [imie] TEXT NOT NULL
, [nazwisko] TEXT NOT NULL
, [telefon] TEXT NOT NULL
, [specjalista] INTEGER NOT NULL
, CONSTRAINT [PK_pracownik] PRIMARY KEY ([Id])
);

CREATE TABLE IF NOT EXISTS [kalendarz] (
  [Id] INTEGER NOT NULL
, [datastart] INTEGER NOT NULL
, [datastop] INTEGER NOT NULL
, [serwisowanysamochod] INTEGER NOT NULL
, [pracownikodp] INTEGER NOT NULL
, [notatka] TEXT NOT NULL
, [koszt] NUMERIC(17,2) NOT NULL
, CONSTRAINT [PK_kalendarz] PRIMARY KEY ([Id])
);


CREATE TABLE IF NOT EXISTS [raporty] (
  [Id] INTEGER NOT NULL
, [raportklient] TEXT NOT NULL
, [raportmiesieczny] TEXT NOT NULL
, CONSTRAINT [PK_raporty] PRIMARY KEY ([Id])
);

CREATE TABLE IF NOT EXISTS [samochod] (
  [Id] INTEGER NOT NULL
, [vin] TEXT NOT NULL
, [marka] TEXT NOT NULL
, [numerrejestracyjny] TEXT NOT NULL
, [wlasciciel] INTEGER NOT NULL
, CONSTRAINT [PK_samochod] PRIMARY KEY ([Id])
);

CREATE TABLE IF NOT EXISTS [serwis] (
  [Id] INTEGER NOT NULL
, [samochodserwisowany] INTEGER NOT NULL
, [dataodbioru] INTEGER NOT NULL
, [dataoddania] INTEGER NOT NULL
, [typzgloszenia] TEXT NOT NULL
, [informacjeuzytkownika] TEXT NOT NULL
, CONSTRAINT [PK_serwis] PRIMARY KEY ([Id])
);

CREATE TABLE IF NOT EXISTS [stanowiska] (
  [Id] INTEGER NOT NULL
, [identyfikator] TEXT NOT NULL
, [nazwa] TEXT NOT NULL
, CONSTRAINT [PK_stanowiska] PRIMARY KEY ([Id])
);

