% sorteer-stap waarbij grotere elementen naar rechts bubbelen: als het eerste
% element in de lijst groter is dan het tweede element: verwissel
bubble_sort_step([Eerste, Tweede | Rest], [Tweede | GesorteerdRest]) :-
    Eerste > Tweede,
    bubble_sort_step([Eerste | Rest], GesorteerdRest).

bubble_sort_step([Eerste, Tweede | Rest], [Eerste | GesorteerdRest]) :-
    Eerste =< Tweede,
    bubble_sort_step([Tweede | Rest], GesorteerdRest).

% een lijst met 1 element hoeft niet meer te bubbelen
bubble_sort_step([LaatsteElement], [LaatsteElement]).

% Controle of een lijst al gesorteerd is (van klein naar groot)
is_sorted([]).
is_sorted([_]).
is_sorted([Eerste, Tweede | Rest]) :-
    Eerste =< Tweede,
    is_sorted([Tweede | Rest]).

% De hoofdregel voor bubble_sort: herhaal bubble-stappen tot de reeks is gesorteerd
bubble_sort(OrigineleLijst, GesorteerdeLijst) :-
    \+ is_sorted(OrigineleLijst),
    bubble_sort_step(OrigineleLijst, NieuweLijst),
    bubble_sort(NieuweLijst, GesorteerdeLijst).

% als de lijst al gesorteerd is, zijn we klaar
bubble_sort(GesorteerdeLijst, GesorteerdeLijst) :-
    is_sorted(GesorteerdeLijst).
