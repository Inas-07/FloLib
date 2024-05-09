using HarmonyLib;
using SNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloLib.Networks.Inject
{
    namespace FloLib.Networks.Inject
    {
        // Token: 0x02000038 RID: 56
        [HarmonyPatch]
        internal class Inject_OnRecallDone
        {
            // Token: 0x14000007 RID: 7
            // (add) Token: 0x06000145 RID: 325 RVA: 0x000059A4 File Offset: 0x00003BA4
            // (remove) Token: 0x06000146 RID: 326 RVA: 0x000059D8 File Offset: 0x00003BD8
            public static event Action OnRecallDone;

            // Token: 0x06000147 RID: 327 RVA: 0x00005A0B File Offset: 0x00003C0B
            [HarmonyPostfix]
            [HarmonyPatch(typeof(SNet_SyncManager), nameof(SNet_SyncManager.OnRecallDone))]
            private static void Post_OnRecallDone(SNet_SyncManager __instance)
            {
                OnRecallDone?.Invoke();
            }
        }
    }

}
