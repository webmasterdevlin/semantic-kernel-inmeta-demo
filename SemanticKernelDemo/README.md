Configure an OpenAI endpoint

```powershell

dotnet user-secrets set "Global:LlmService" "OpenAI"
dotnet user-secrets set "OpenAI:ModelType" "chat-completion"
dotnet user-secrets set "OpenAI:ChatCompletionModelId" "gpt-3.5-turbo"
dotnet user-secrets set "OpenAI:ApiKey" "... your OpenAI key ..."
dotnet user-secrets set "OpenAI:OrgId" "... your ord ID ..."
```

Configure an Azure OpenAI endpoint

```powershell

dotnet user-secrets set "Global:LlmService" "AzureOpenAI"
dotnet user-secrets set "AzureOpenAI:DeploymentType" "chat-completion"
dotnet user-secrets set "AzureOpenAI:ChatCompletionDeploymentName" "gpt-35-turbo"
dotnet user-secrets set "AzureOpenAI:Endpoint" "... your Azure OpenAI endpoint ..."
dotnet user-secrets set "AzureOpenAI:ApiKey" "... your Azure OpenAI key ..."
```

## Running the sample

After configuring the sample, to build and run the console application just hit `F5`.

To build and run the console application from the terminal use the following commands:

```powershell
dotnet build
dotnet run
```

#### Creating a new function via SK VS Code extension

- Click create your first semantic function
- Create a new folder name plugins.
- Create a folder name BlankSkill e.g. GrammarSkill
- Create the semantic function files in the BlankSkill folder and name it base on what it does. e.g. Summarize
