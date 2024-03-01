package main

import (
	"fmt"
	"os"
	"strconv"
	"strings"
	"unicode"
)

func main() {
	arr := getElementsFromFile("day1/text.txt")
	fmt.Println(len(arr))
	var total = 0
	for _, element := range arr {
		var str string
		for i := 0; i < len(element); i++ {
			if unicode.IsDigit(rune(element[i])) {
				str = str + string(element[i])
				break
			}
		}
		for i := len(element) - 1; i >= 0; i-- {
			if unicode.IsDigit(rune(element[i])) {
				str = str + string(element[i])
				break
			}
		}
		val, err := strconv.Atoi(str)
		if err != nil {
			panic(err.Error())
		}
		total += val
	}
	println(total)
}

func getElementsFromFile(path string) []string {
	res, err := os.ReadFile(path)
	if err != nil {
		panic(err.Error())
	}
	return strings.Split(string(res), "\n")
}
