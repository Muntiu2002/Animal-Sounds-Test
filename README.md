# Animal Sounds – Proiect C#

## Descriere
Este o aplicatie de tip consola in C# care permite utilizatorului sa selecteze un animal si sa asculte sunetul acestuia. 

## Design Patterns folosite

- **Singleton**: Clasa `TaskQueueManager` este implementata ca un singleton pentru a gestiona coada de comenzi.
- **Command**: Comenzile (`ICommand` si clasele ce implementeaza aceasta interfata) sunt puse in coada si executate, separand logica apelului de executie.

## Testare

- Testarea instantei singleton (`Instance_ShouldReturnSameObject`)
- Testarea executarii comenzilor fara exceptii (`EnqueueCommand_ShouldExecuteWithoutException`)

## Cum se rulează
- Compileaza si ruleaza proiectul `Animal sounds`.
- Ruleaza testele din proiectul `AnimalTasks`.
