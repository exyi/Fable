﻿namespace System
open System.Reflection

[<assembly: AssemblyVersionAttribute("0.6.5")>]
[<assembly: AssemblyMetadataAttribute("fableCoreVersion","0.6.3")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.6.5"
    let [<Literal>] InformationalVersion = "0.6.5"
