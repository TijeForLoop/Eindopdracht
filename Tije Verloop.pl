biologie(thomas).
economie(thomas).
economie(yuan).
frans(anna).
frans(mila).
geschiedenis(thomas).
geschiedenis(wouter).
geschiedenis(yuan).
geschiedenis(mila).
natuurkunde(anna).
natuurkunde(helene).
scheikunde(anna).
scheikunde(thomas).
scheikunde(helene).
wiskunde_a(thomas).
wiskunde_a(yuan).
wiskunde_b(anna).
wiskunde_b(helene).
wiskunde_c(wouter).
nt(Persoon) :- natuurkunde(Persoon), scheikunde(Persoon), wiskunde_b(Persoon).
ng(Persoon) :- biologie(Persoon), scheikunde(Persoon), wiskunde_a(Persoon).
em(Persoon) :- economie(Persoon), geschiedenis(Persoon), wiskunde_a(Persoon).
cm(Persoon) :- geschiedenis(Persoon), (frans(Persoon); wiskunde_c(Persoon)).
ng_em(Persoon) :- ng(Persoon), em(Persoon).