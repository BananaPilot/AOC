package main

import (
	"fmt"
	"os"
	"strconv"
	"unicode"
)

func main() {
	arr := stringArray(getElementsFromFile("day1/text.txt"))
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

func getElementsFromFile(path string) []byte {
	res, err := os.ReadFile(path)
	if err != nil {
		panic(err.Error())
	}
	return res
}

func stringArray(bArray []byte) []string {
	var strings []string
	var res string
	for _, element := range bArray {
		if string(element) != "\n" {
			res += string(element)
		} else {
			strings = append(strings, res)
			res = ""
		}
	}
	return strings
}
