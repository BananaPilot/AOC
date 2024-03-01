package main

import (
	"os"
	"strconv"
	"strings"
)

func main() {
	games := getMap(getTextArray("day2/text.txt"))
	var importantGames []string
	for key, value := range games {
		red := 0
		green := 0
		blue := 0
		games := strings.Split(value, ";")
		for _, game := range games {
			cubes := strings.Split(game, ",")
			for _, cube := range cubes {
				cube = strings.Trim(cube, " ")
				res := strings.Split(cube, " ")
				num, err := strconv.Atoi(res[0])
				if err != nil {
					panic(err.Error())
				}
				switch res[1] {
				case "red":
					if num > red {
						red = num
					}
					break
				case "green":
					if num > green {
						green = num
					}
					break
				case "blue":
					if num > blue {
						blue = num
					}
					break
				}
			}
		}
		if red <= 12 && green <= 13 && blue <= 14 {
			println("correct: ", red, green, blue)
			importantGames = append(importantGames, key)
		} else {
			println("incorrect: ", red, green, blue)
		}
	}
	total := 0
	for _, element := range importantGames {
		res := strings.Split(element, " ")
		num, err := strconv.Atoi(res[1])
		if err != nil {
			panic(err.Error())
		}
		total += num
	}
	println(total)
}

func getTextArray(path string) []string {
	res, err := os.ReadFile(path)
	if err != nil {
		panic(err.Error())
	}
	return strings.Split(string(res), "\n")
}

func getMap(arr []string) map[string]string {
	var myMap = make(map[string]string)
	for _, element := range arr {
		keyValue := strings.Split(element, ":")
		myMap[keyValue[0]] = keyValue[1]
	}
	return myMap
}
