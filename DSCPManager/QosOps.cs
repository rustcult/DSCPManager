using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace DSCPManager
{
    public static class QosOps
    {
        public static List<QosPolicy> qosPoliciesList = new List<QosPolicy>();
        public static string[] qosPoliciesNameList = Array.Empty<string>();
        public static void ReadQosPolicy()
        {
            qosPoliciesList.Clear();
            InitialSessionState initial = InitialSessionState.CreateDefault();
            initial.ExecutionPolicy = Microsoft.PowerShell.ExecutionPolicy.Unrestricted;
            Runspace runspace = RunspaceFactory.CreateRunspace(initial);
            runspace.Open();
            PowerShell ps = PowerShell.Create();
            ps.Runspace = runspace;
            ps.AddCommand("Get-NetQosPolicy");
            var policyList = ps.Invoke();


            foreach (PSObject item in policyList)
            {
                string policyName = item.Properties["Name"].Value.ToString();
                string appPathName = "";
                string DSCPValue = "";

                if (item.Properties["AppPathNameMatchCondition"].Value != null)
                {
                    appPathName = item.Properties["AppPathNameMatchCondition"].Value.ToString();
                }
                if (item.Properties["DSCPAction"].Value != null)
                {
                    DSCPValue = item.Properties["DSCPAction"].Value.ToString();
                }

                if (policyName != null && appPathName != null && DSCPValue != null)
                {
                    var policy = new QosPolicy(policyName, appPathName, DSCPValue);
                    qosPoliciesList.Add(policy);
                }
            }
            UpdateNameList();
        }
        public static void DeleteQosPolicy(string name)
        {
            InitialSessionState initial = InitialSessionState.CreateDefault();
            initial.ExecutionPolicy = Microsoft.PowerShell.ExecutionPolicy.Unrestricted;
            Runspace runspace = RunspaceFactory.CreateRunspace(initial);
            runspace.Open();
            PowerShell ps = PowerShell.Create();
            ps.Runspace = runspace;
            qosPoliciesList.Clear();
            ps.AddCommand("Remove-NetQosPolicy")
            .AddParameter("Name", name)
            .AddParameter("Confirm", false);
            var result = ps.Invoke();
            //MessageBox.Show("删除成功");
        }
        public static void UpdateQosPolicy(string name, string key, string value)
        {
            InitialSessionState initial = InitialSessionState.CreateDefault();
            initial.ExecutionPolicy = Microsoft.PowerShell.ExecutionPolicy.Unrestricted;
            Runspace runspace = RunspaceFactory.CreateRunspace(initial);
            runspace.Open();
            PowerShell ps = PowerShell.Create();
            ps.Runspace = runspace;
            qosPoliciesList.Clear();
            ps.AddCommand("Set-NetQosPolicy")
            .AddParameter("Name", name)
            .AddParameter(key, value);
            var result = ps.Invoke();
            //MessageBox.Show("修改成功");
        }
        public static void CreateQosPolicy(QosPolicy policy)
        {
            InitialSessionState initial = InitialSessionState.CreateDefault();
            initial.ExecutionPolicy = Microsoft.PowerShell.ExecutionPolicy.Unrestricted;
            Runspace runspace = RunspaceFactory.CreateRunspace(initial);
            runspace.Open();
            PowerShell ps = PowerShell.Create();
            ps.Runspace = runspace;
            qosPoliciesList.Clear();
            ps.AddCommand("New-NetQosPolicy")
            .AddParameter("Name", policy.PolicyName)
            .AddParameter("AppPathNameMatchCondition", policy.AppPathName)
            .AddParameter("DSCP", policy.DSCPValue);
            var result = ps.Invoke();
            MessageBox.Show("创建成功");
        }
        static void UpdateNameList()
        {
            qosPoliciesNameList = qosPoliciesList.Select(p => p.PolicyName).ToArray();
        }
    }

    public class QosPolicy
    {
        public QosPolicy(string policyName, string appPathName, string DSCPValue)
        {
            this.PolicyName = policyName;
            this.AppPathName = appPathName;
            this.DSCPValue = DSCPValue;
        }

        public string PolicyName { get; set; }
        public string AppPathName { get; set; }
        public string DSCPValue { get; set; }
    }
}
