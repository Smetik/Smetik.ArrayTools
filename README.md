# Smetik.ArrayTools

Библиотека на C# для работы с массивами целых чисел.

## Возможности

- сортировка массива по возрастанию;
- фильтрация элементов по условию;
- поиск элемента;
- получение элемента по индексу.

## Установка

Добавление источника GitHub Packages:

    dotnet nuget add source --username "ВАШ_GITHUB_USERNAME" --password "ВАШ_ТОКЕН" --store-password-in-clear-text --name github "https://nuget.pkg.github.com/Smetik/index.json"

Установка пакета:

    dotnet add package Smetik.ArrayTools --version 1.0.0 --source github

## Пример использования

    using Smetik.ArrayTools;

    int[] numbers = { 5, 2, 9, 1 };
    int[] sorted = ArrayTools.SortAscending(numbers);

## Дополнительно

- пакет опубликован в GitHub Packages;
- настроены CI/CD через GitHub Actions;
- документация находится в GitHub Wiki.
