#r @"..\Altassian.Proxy\bin\Release\Altassian.Proxy.dll"

open Altassian.Proxy.com.atlassian.confluence

let service = new ConfluenceSoapServiceService(Url = @"https://SERVER_NAME/rpc/soap-axis/confluenceservice-v2?WSDL")
let token = service.login("LOGIN","PASSWORD")

service.getSpaces(token)
|> Seq.iter (fun x-> printfn "%s" x.name )

service.Dispose()