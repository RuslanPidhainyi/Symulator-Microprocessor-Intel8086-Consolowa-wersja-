# Symulator Microprocessor Intel8086 (Consolowa wersja w języku polskim)
----
# Opis projektu:
• Symulator posiada oprawę konsolowa
• Program obsługuje rozkazy MOV oraz XCHG
• Projekt symulatora rozkazów napisany został w języku C#

# Opis działania programu:
Microprocessors 8086 ma 4 rejestry. Może przechowywać wartości w systemie szesnastkowym. 

---

# Krok 1 – Wpisywania wartości w rejestry 

W pierwszym kroku program prosi nas o podanie wartości pierwszego rejestru. Wyświetla się instrukcja jak może być wpisana wartość w
systemie szesnastkowym.

https://github.com/RuslanPidhainyi/Symulator-Microprocessor-Intel8086-Consolowa-wersja-/assets/136593314/e29abb48-661e-4322-be36-42c49a89fdbc

![image](https://github.com/RuslanPidhainyi/Symulator-Microprocessor-Intel8086-Consolowa-wersja-/assets/136593314/c6df979f-6766-4889-bb3b-b3c840a5ff8f)


Musimy podać wartości w nasze rejestry 0-9 lub A-F. Tych rejestrów
będzie 8 (AL., AH, BL, BH, CL, CH, DL, DH). 


# Pierwsza Walidacja

https://github.com/RuslanPidhainyi/Symulator-Microprocessor-Intel8086-Consolowa-wersja-/assets/136593314/fa934014-d9e6-45e8-a787-bb02faa34e63

Jeżeli podamy wartość błędną (nie szesnastkową) wyskakuje powiadomienie, że wartość została źle wpisana. Poprosi, żeby jeszcze
raz wpisałeś wartość poprawnie do naszego rejestru.

---

# Krok 2 – Wybór między MOV i XCHG

![image](https://github.com/RuslanPidhainyi/Symulator-Microprocessor-Intel8086-Consolowa-wersja-/assets/136593314/e032fdff-40aa-43e8-b7e7-217529e8c8ae)

Jak podamy we wszystkich rejestrach wartość, od razu otrzymamy wynik z naszymi wartościami. Pod wyświetlanymi wartościami
otrzymamy pytanie o podanie rozkazu MOV lub XCHG. Możemy wprowadzić rozkaz podając z klawiatury: 

1 – rozkaz MOV.
2 – rozkaz XCHG. 

https://github.com/RuslanPidhainyi/Symulator-Microprocessor-Intel8086-Consolowa-wersja-/assets/136593314/ea51a30b-4af1-47ba-86da-449989a890fa

Jeżeli wpiszemy cokolwiek oprócz 1 albo 2 otrzymamy wiadomość, że nie spełnia warunku. 

---

# Krok 3 - MOV 

https://github.com/RuslanPidhainyi/Symulator-Microprocessor-Intel8086-Consolowa-wersja-/assets/136593314/3c1cbdca-8bb0-4832-b33d-d859e9d05995

Jeżeli wybrałeś 1 czyli MOV. To wtedy wyświetli nam kolejne pytania. I musimy wpisać nasze rejestry (AL – DH)

https://github.com/RuslanPidhainyi/Symulator-Microprocessor-Intel8086-Consolowa-wersja-/assets/136593314/fd6ffb52-6328-4b69-a9ce-dcaf94c6b6a5

https://github.com/RuslanPidhainyi/Symulator-Microprocessor-Intel8086-Consolowa-wersja-/assets/136593314/03a84282-3bbb-4fd0-8861-ef3f54ccbf87

A jeżeli wpiszemy coś innego to wypisze nam, że mamy błędny rejestr i wtedy musimy jeszcze raz wybrać poprawny rejestr. 

https://github.com/RuslanPidhainyi/Symulator-Microprocessor-Intel8086-Consolowa-wersja-/assets/136593314/409bdb47-8926-4ab9-97c0-0e908eac98ae

Jak wpiszemy poprawny rejestry, otrzymamy wyniki z rozkazu MOV.
Rozkazy MOV odpowiedzialny za przeniesienie danych z jednego rejestru do innego wybranego przez użytkownika rejestru.
W moim przepadku wybrałem rejestr „al” i „dh” i one przeniosło mi dane z jednego rejestru „dh” na „al”. 

---

# Krok 4 – Kontynuacja programu 
![image](https://github.com/RuslanPidhainyi/Symulator-Microprocessor-Intel8086-Consolowa-wersja-/assets/136593314/a3cccf6d-de2b-470a-81f8-f389ec103e1a)

Jeżeli chcesz kontynuować możesz kliknąć „Enter” lub dowolną klawisze, a jeżeli chcesz zamknąć pogram to musisz wpisać „x” i nacisnąć „Enter”. 

---

# Krok 5 – XCHG 

![image](https://github.com/RuslanPidhainyi/Symulator-Microprocessor-Intel8086-Consolowa-wersja-/assets/136593314/189cc398-2c8a-4ba0-90b8-20cfec2d3fda)

Na pytania: „Podaj rozkaz symulacji MOV lub XCHG. Wpisz w konsole 1 lub 2 żeby wybrać MOV lub XCHG.”
My wpiszemy 2 czyli XCHG to też musimy podać dwa rejestry. I po podaniu rejestrów wyskoczy u nas wyniki z XCHG.
Rozkaz XCHG zmienia nam dane rejestrów które wskazaliśmy. 


