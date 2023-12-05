### Login With System-assigned Managed Identity

> [!NOTE]
>
> "Login With System-assigned Managed Identity" is only supported on GitHub self-hosted runners and the self-hosted runners need to be hosted by Azure virtual machines.

Before you login with system-assigned managed identity, you need to create an Azure virtual machine to host the GitHub self-hosted runner.

- Create an Azure virtual machine
  - [Create a Windows virtual machine](https://learn.microsoft.com/azure/virtual-machines/windows/quick-create-portal)
  - [Create a Linux virtual machine](https://learn.microsoft.com/azure/virtual-machines/linux/quick-create-portal?tabs=ubuntu)
- [Configure system-assigned managed identity on the Azure virtual machine](https://learn.microsoft.com/entra/identity/managed-identities-azure-resources/qs-configure-portal-windows-vm#system-assigned-managed-identity)
- Install required softwares on the Azure virtual machine
  - [Install PowerShell](https://learn.microsoft.com/powershell/scripting/install/installing-powershell)
  - [Install Azure CLI](https://learn.microsoft.com/cli/azure/install-azure-cli)
    - If you want to run Azure CLI Action, [Install Docker](https://docs.docker.com/engine/install/).
  - [Install Azure PowerShell](https://learn.microsoft.com/powershell/azure/install-azure-powershell)
- [Configure the Azure virtual machine as a GitHub self-hosted runner](https://docs.github.com/actions/hosting-your-own-runners/managing-self-hosted-runners/adding-self-hosted-runners)

After it, create GitHub Action secrets for following values: (Refer to [Using secrets in GitHub Actions](https://docs.github.com/actions/security-guides/using-secrets-in-github-actions).)

- AZURE_SUBSCRIPTION_ID: the Subscription ID
- AZURE_TENANT_ID: the Tenant ID

Now you can try the workflow to login with system-assigned managed identity.