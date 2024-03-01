package main

import (
	"awesomeProject/day2/types"
	"os"
	"strings"
)

func main() {
	games := getGames()
	for key, value := range games {
		println(key, value.Game1, value.Game2, value.Game3)
	}
}

func getTextArray(path string) []string {
	res, err := os.ReadFile(path)
	if err != nil {
		panic(err.Error())
	}
	return strings.Split(string(res), "\n")
}

func getGames() map[string]types.Games {
	var games map[string]types.Games
	for index, element := range getTextArray("day2/text.txt") {
		id := strings.Split(element, ":")
		gamesSplit := strings.Split(element, ";")
		games[id[index]] = types.Games{
			Game1: gamesSplit[0],
			Game2: gamesSplit[1],
			Game3: gamesSplit[2],
		}
	}
	return games
}
