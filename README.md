# Proiect_PIU
### Andries George Serban - Grupa 3122A
### Tema proiectului este - Biblioteca
### Să se scrie programul pentru gestionarea împrumuturilor cărților dintr-o bibliotecă. O carte poate să existe în mai mult exemplare. Pe lângă operațiile de adăugare, editare, ștergere pentru un autor sau carte sau pentru persoana care împrumută, se vor afișa următoarele situații:
- [ ] pentru o anumită carte se va afișa dacă este disponibilă sau nu;
- [ ] pentru o anumită persoană se va afișa numărul de cărți împrumutate; dacă numărul
depășește o anumită valoare stabilită în secțiunea de configurări, va apare un mesaj
de atenționare și nu se va permite împrumutul unei alte cărți.

### Aplicatie pentru gestiunea unei biblioteci.
#### O aplicatie simpla de tip Windows Form utilizatorul cu o interfata minimalista in care sunt expuse urmatoarele:
1. Cartile aflate curent in biblioteca.
2. Optiunea pentru a adauga carti in memoria programului, folosind campuri input si un buton care realizeaza adaugarea cand sunt indeplinite cerintele.
3. Un buton de "Refresh" care actualizeaza informatiile afisate pentru cartile existente in fisier
4. Un buton de cautare care permite cautarea in memorie dupa o anumita carte, criteriul de cautare fiind numele cartii.

#### O aplicatie de tip Terminal, utilizatorul este intampinat cu un meniu in care sunt expuse urmatoarele optiuni:
1. Introducerea unei noi cart in fisier de la tastatura
2. Afisarea informatiilor pentru ultima carte introdusa
3. Afisarea tuturor cartilor salvate in fisier
4. Salvarea cartii introduse de la tastatura in fisier
5. Cauta o carte in toate cele existente dupa unul din criteriile urmatoare: Titlu, Autor, AnPublicatie, SubiectLiterar, Detinator
6. Inchiderea programului


Clasa utilizata in aplicatie este clasa Carte.

Datele introduse de utilizator sunt salvate intr-un fisier tip text pentru a putea fi folosite in continuare in aplicatie.
Informatiile se salveaza in fisier ca un sir de caractere cu separatorul ";" intre fiecare atribut diferit existent in acel sir. Acest lucru va usura modul de extragere a datelor pentru a putea fi afisate sau editate.

Aplicatia verifica datele care sunt introduse de utilizator si in cazul in are acestea nu se incadreaza in tiparul intrus programul afiseaza o eroare.
