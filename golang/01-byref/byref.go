package main

import "fmt"

func main() {
	name := "Jake"
	age := 24

	fmt.Println(name, "is currently", age, "years old.")
	haveBirthday(name, &age)
	fmt.Println("Now,", name, "is", age, "years old.")
}

func haveBirthday(name string, age *int) int {
	*age++
	fmt.Println("Happy birthday,", name, "!")
	return *age
}
