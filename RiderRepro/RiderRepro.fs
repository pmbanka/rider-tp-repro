namespace RiderRepro

module Foo =
    open SecondProject
    
    let x = Config.config.DB.ConnectionString
    
    ()
