#r @"..\Altassian.Proxy\bin\Release\Altassian.Proxy.dll"

open Altassian.Proxy.com.atlassian.jira

let service = new JiraSoapServiceService(Url = @"https://SERVER_NAME/rpc/soap/jirasoapservice-v2?wsdl")
let token = service.login("LOGIN","PASSWORD")

service.getIssuesFromJqlSearch(token, "status = open", 10)
|> Seq.iter (fun x-> printfn "%s" x.summary )

service.Dispose()
