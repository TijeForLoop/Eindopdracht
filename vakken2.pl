geschiedenis(yuan, julius_caesar).
geschiedenis(peter, charles_darwin).
economie(peter, karl_marx).
natuurkunde(wouter, albert_einstein).
scheikunde(wouter, alfred_nobel).
biologie(wouter, charles_darwin).

nt(Persoon) :- natuurkunde(Persoon, _), scheikunde(Persoon, _).
ng(Persoon) :- biologie(Persoon, _), scheikunde(Persoon, _).
em(Persoon) :- economie(Persoon, _), geschiedenis(Persoon, _).
cm(Persoon) :- geschiedenis(Persoon, _).