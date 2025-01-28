let x = 10
let y = 20

let swap x y =
    (y, x)

let (x', y') = swap x y
printf "%d %d" x' y' // Output: 20 10

//Alternative solution using a different approach
let swap2 x y = 
    let mutable x2 = x
    let mutable y2 = y
    let temp = x2
    x2 <- y2
    y2 <- temp
    (x2,y2)

let (x'', y'') = swap2 x y
printf "%d %d" x'' y''