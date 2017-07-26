namespace SecondProject

open FSharp.Configuration

module Config =
    type TestConfig = YamlConfig<"Config.yaml">
    let config = TestConfig()
    let cStr = config.DB.ConnectionString
