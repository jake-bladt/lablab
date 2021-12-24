fn main() {
    let mut clargs = std::env::args().skip(1);
    let key = clargs.next().unwrap();
    let val = clargs.next().unwrap();
    println!("The key is '{}'. The value is '{}'.", key, val);
