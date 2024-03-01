package main

import (
	"os"
	"strings"
)

func main() {

}

func getTextArray(path string) []string {
	res, err := os.ReadFile(path)
	if err != nil {
		panic(err.Error())
	}
	return strings.Split(string(res), "\n")
}

func getGames() map[string]string {
	var games = make(map[string]string)
	for _, element := range getTextArray("day2/text.txt") {
		id := strings.Split(element, ":")
		games[id[0]] = id[1]
	}
	return games
}
