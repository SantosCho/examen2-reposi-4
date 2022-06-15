namespace Library1

module fibo1=
   let rec fibo n = if n <=2 then 1 else fibo (n - 1) + fibo (n - 2)

module fibo2=
   let fibo1 n =
      let mutable a=1
      let mutable b=1
      let mutable c=0
      if n=1 then 1 
      elif n=2 then 1 
      else 
       for i in 3..n do
         c<-a+b
         a<-b
         b<-c
   
       c 
type Class1() = 
    member this.X = "F#"
