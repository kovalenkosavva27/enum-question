# Преобразование enum

## Описание

Проект использует базу данных, где статусы хранятся в виде строк: "AVAILABLE", "REMOVED", "SCREEN_OUT", "ENROLL_IN_STUDY", "STOPPED". Заказчик хочет, чтобы в коде у полей enum был "нормальный" нейминг: Available, Removed, ScreenOut, EnrollInStudy, Stopped.

## Проблема

При использовании простого метода `.HasConversion<string>();` возникает ошибка конвертации, а именно:

```plaintext
Cannot convert string value 'ENROLL_IN_STUDY' from the database to any value in the mapped 'SubjectStatuses' enum.
```
## Вопрос

Есть ли более простое решение, чем создавать свой конвертер?
