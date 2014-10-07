
//La división redondea automáticamente. Ej: 24/10 = 2
let extraeDigitos x = 
    x/10, x - (x/10 *10)   

let sumaDigitos tupla = 
    let x, y = tupla
    x + y
        
let numeros10 = 
    [
        for i in 11..99 do
            if (sumaDigitos (extraeDigitos i)) = 10 then
                yield i
    ]
            
[<EntryPoint>]
let main argv = 
    printfn "%A" numeros10
  
    0 // return an integer exit code
