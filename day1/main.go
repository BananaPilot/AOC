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
		str := SearchFirstDigit(element)
		str += rSearchFirstDigit(element)
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

func rSearchFirstDigit(str string) string {
	for i := len(str) - 1; i >= 0; i-- {
		if unicode.IsDigit(rune(str[i])) {
			return string(str[i])
		}
	}
	return ""
}

func SearchFirstDigit(str string) string {
	for i := 0; i < len(str); i++ {
		if unicode.IsDigit(rune(str[i])) {
			str = str + string(str[i])
			break
		}
	}
	return ""
}
