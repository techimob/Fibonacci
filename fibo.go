package main

import "fmt"

func fib_generator() chan int {
  c := make(chan int)

  go func() { 
    for i, j := 0, 1; ; i, j = i+j,i {
        c <- i
    }
  }()

  return c
}

func main() {
    c := fib_generator()
    for n := 0; n < 12 ; n++ {
        fmt.Println(<- c)
    }
}
