# Выборка элементов определенной длины из массива.

Программа содержит функционал обработки и оптимизации вводимых строк, с последующим выводом результирующего отфильтрованного массива.

В программе используются следующие сущности:

1. Статический класс **Filter** - содержит основной метод фильтрации **ByLength(string[] array)**. <br>С блок схомой алгоритма можно ознакоимиться по [ссылке](https://kroki.io/mermaid/svg/eNp1kd1Og0AQha_hKSZ7BcFagWoTQ0mqoiYSTQo1MRsuWqHtpnVpYPEnje8u7C5L29Q7mDlnds58y2K2XUF8p2sktQ3kzf2IzQp27fXnvjcvfChZQegSJ3BPNiwrbn7CjC7ZyjCRCb2eD_mWkZyWuN94X8SPcivz52xTZeVZUyOUwYZ8EAYjcFE_0TU5go8jqYMbxXte0UZxkTSbOaJH0-zb5m0iWmU1X_IAt4_B7RNMgmgaxjCeTMZvEAbPD_Fj7eYuPoDmaWYbBpimrvFvXl3khb0j4Mklz0XAX11rGrUC4sk0EAss7B0SKkwSKQRvJPKg2lIrDh2pixHPYlmIR3FlfYCJZSXKcT8Oo9YyaHSDbmM9o2m3TacssrLaMIzUlUWhPg3Nvlpw_PGkeVt2RRBnJy7swwVf2zkezaqCGjXSgKYKp6jKZ0xl20t7iQ_BXXbgBNf1EbgoiFtsr-NwGkQSmKPiO3vAnBaYs1ufBna00MJVwNb_AHOPIlxhJA8rTlcvrCYIhFdSOcSSLK8Ou43V2O6got6CPHltHeAPYA4MuA)
2. Статический класс **IOFunc** - содержит методы обработки строк и символов.

Класс IOFunc включает в себя:

- **RequestString()** - запрос пользовательской строки.
- **OptimizeString(string value)** - удаляет лишние символы пробела, запятые и точки.
- **ShowArray(string[] array)** - выводит массив.
