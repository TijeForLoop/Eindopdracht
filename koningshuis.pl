moeder(beatrix, constantijn).
moeder(beatrix, friso).
moeder(beatrix, willem_alexander).
moeder(christina, bernardo).
moeder(christina, juliana_jr).
moeder(christina, nicolás).
moeder(emma, wilhelmina).
moeder(irene, carlos).
moeder(irene, jaime).
moeder(irene, margarita).
moeder(juliana, beatrix).
moeder(juliana, christina).
moeder(juliana, irene).
moeder(juliana, margriet).
moeder(margarita, julia).
moeder(margriet, bernhard).
moeder(margriet, floris).
moeder(margriet, maurits).
moeder(margriet, pieter_christiaan).
moeder(wilhelmina, juliana).
vader(bernardo, isabel).
vader(bernhard, benjamin).
vader(bernhard, isabella).
vader(bernhard, samuel).
vader(carlos, carlos_jr).
vader(constantijn, claus_casimir).
vader(constantijn, eloise).
vader(constantijn, leonore).
vader(floris, eliane).
vader(floris, magali).
vader(friso, luana).
vader(friso, zaria).
vader(maurits, anna).
vader(maurits, felicia).
vader(maurits, lucas).
vader(pieter_christiaan, emma_jr).
vader(pieter_christiaan, pieter).
vader(willem_alexander, alexia).
vader(willem_alexander, amalia).
vader(willem_alexander, ariane).
ouder(Ouder, Kind) :- vader(Ouder, Kind); moeder(Ouder, Kind).
kind(Kind, Ouder) :- vader(Ouder, Kind); moeder(Ouder, Kind).
broer_of_zus(Kind1, Kind2) :- ouder(Ouder, Kind1), ouder(Ouder, Kind2), Kind1 \= Kind2.