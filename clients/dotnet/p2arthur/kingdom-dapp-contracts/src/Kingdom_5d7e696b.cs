using System;
using Algorand;
using Algorand.Algod;
using Algorand.Algod.Model;
using Algorand.Algod.Model.Transactions;
using AVM.ClientGenerator;
using AVM.ClientGenerator.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVM.ClientGenerator.ABI.ARC56;
using Algorand.AVM.ClientGenerator.ABI.ARC56;

namespace Arc56.Generated.p2arthur.kingdom_dapp_contracts.Kingdom_5d7e696b
{


    public class KingdomProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public KingdomProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class CitizenType : AVMObjectType
            {
                public ulong CitizenContribution { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCitizenContribution = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCitizenContribution.From(CitizenContribution);
                    ret.AddRange(vCitizenContribution.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static CitizenType Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new CitizenType();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCitizenContribution = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCitizenContribution.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCitizenContribution = vCitizenContribution.ToValue();
                    if (valueCitizenContribution is ulong vCitizenContributionValue) { ret.CitizenContribution = vCitizenContributionValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as CitizenType);
                }
                public bool Equals(CitizenType? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CitizenType left, CitizenType right)
                {
                    return EqualityComparer<CitizenType>.Default.Equals(left, right);
                }
                public static bool operator !=(CitizenType left, CitizenType right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="kingdomName">The name of the kingdom </param>
        /// <param name="kingdomDescription"> </param>
        /// <param name="tokenName"> </param>
        /// <param name="tokenSymbol"> </param>
        /// <param name="kingdomImage"> </param>
        /// <param name="kingdomPrmaryColor"> </param>
        /// <param name="kingdomSecondaryColor"> </param>
        /// <param name="kingdomBackgroundColor"> </param>
        /// <param name="kingdomAccentColor"> </param>
        /// <param name="kingdomTextColor"> </param>
        /// <param name="repoId"> </param>
        public async Task CreateKingdom(string kingdomName, string kingdomDescription, string tokenName, string tokenSymbol, string kingdomImage, string kingdomPrmaryColor, string kingdomSecondaryColor, string kingdomBackgroundColor, string kingdomAccentColor, string kingdomTextColor, ulong repoId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 33, 131, 39 };
            var kingdomNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); kingdomNameAbi.From(kingdomName);
            var kingdomDescriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); kingdomDescriptionAbi.From(kingdomDescription);
            var tokenNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tokenNameAbi.From(tokenName);
            var tokenSymbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tokenSymbolAbi.From(tokenSymbol);
            var kingdomImageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); kingdomImageAbi.From(kingdomImage);
            var kingdomPrmaryColorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); kingdomPrmaryColorAbi.From(kingdomPrmaryColor);
            var kingdomSecondaryColorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); kingdomSecondaryColorAbi.From(kingdomSecondaryColor);
            var kingdomBackgroundColorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); kingdomBackgroundColorAbi.From(kingdomBackgroundColor);
            var kingdomAccentColorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); kingdomAccentColorAbi.From(kingdomAccentColor);
            var kingdomTextColorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); kingdomTextColorAbi.From(kingdomTextColor);
            var repoIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); repoIdAbi.From(repoId);

            var result = await base.CallApp(new List<object> { abiHandle, kingdomNameAbi, kingdomDescriptionAbi, tokenNameAbi, tokenSymbolAbi, kingdomImageAbi, kingdomPrmaryColorAbi, kingdomSecondaryColorAbi, kingdomBackgroundColorAbi, kingdomAccentColorAbi, kingdomTextColorAbi, repoIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateKingdom_Transactions(string kingdomName, string kingdomDescription, string tokenName, string tokenSymbol, string kingdomImage, string kingdomPrmaryColor, string kingdomSecondaryColor, string kingdomBackgroundColor, string kingdomAccentColor, string kingdomTextColor, ulong repoId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 33, 131, 39 };
            var kingdomNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); kingdomNameAbi.From(kingdomName);
            var kingdomDescriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); kingdomDescriptionAbi.From(kingdomDescription);
            var tokenNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tokenNameAbi.From(tokenName);
            var tokenSymbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tokenSymbolAbi.From(tokenSymbol);
            var kingdomImageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); kingdomImageAbi.From(kingdomImage);
            var kingdomPrmaryColorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); kingdomPrmaryColorAbi.From(kingdomPrmaryColor);
            var kingdomSecondaryColorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); kingdomSecondaryColorAbi.From(kingdomSecondaryColor);
            var kingdomBackgroundColorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); kingdomBackgroundColorAbi.From(kingdomBackgroundColor);
            var kingdomAccentColorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); kingdomAccentColorAbi.From(kingdomAccentColor);
            var kingdomTextColorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); kingdomTextColorAbi.From(kingdomTextColor);
            var repoIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); repoIdAbi.From(repoId);

            return await base.MakeTransactionList(new List<object> { abiHandle, kingdomNameAbi, kingdomDescriptionAbi, tokenNameAbi, tokenSymbolAbi, kingdomImageAbi, kingdomPrmaryColorAbi, kingdomSecondaryColorAbi, kingdomBackgroundColorAbi, kingdomAccentColorAbi, kingdomTextColorAbi, repoIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///This method is used to claim the nomination tokens.
        ///It checks if the sender is the king of the kingdom.
        ///</summary>
        public async Task ClaimNominationTokens(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 252, 161, 144 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClaimNominationTokens_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 252, 161, 144 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Constructor Bare Action
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            var result = await base.CallApp(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            return await base.MakeTransactionList(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiS2luZ2RvbSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJDaXRpemVuVHlwZSI6W3sibmFtZSI6ImNpdGl6ZW5fY29udHJpYnV0aW9uIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVLaW5nZG9tIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imtpbmdkb21OYW1lIiwiZGVzYyI6IlRoZSBuYW1lIG9mIHRoZSBraW5nZG9tIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJraW5nZG9tRGVzY3JpcHRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuTmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5TeW1ib2wiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imtpbmdkb21JbWFnZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoia2luZ2RvbVBybWFyeUNvbG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJraW5nZG9tU2Vjb25kYXJ5Q29sb3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imtpbmdkb21CYWNrZ3JvdW5kQ29sb3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imtpbmdkb21BY2NlbnRDb2xvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoia2luZ2RvbVRleHRDb2xvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVwb0lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsYWltTm9taW5hdGlvblRva2VucyIsImRlc2MiOiJUaGlzIG1ldGhvZCBpcyB1c2VkIHRvIGNsYWltIHRoZSBub21pbmF0aW9uIHRva2Vucy5cbkl0IGNoZWNrcyBpZiB0aGUgc2VuZGVyIGlzIHRoZSBraW5nIG9mIHRoZSBraW5nZG9tLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NCwiYnl0ZXMiOjl9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MX19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6Wzk0LDEwNl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1Niw0NzZdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNpdGl6ZW5zIGNhbiBwZXJmb3JtIHRoaXMgYWN0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDY0XSwiZXJyb3JNZXNzYWdlIjoiT25seSB0aGUga2luZyBjYW4gcGVyZm9ybSB0aGlzIGFjdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1N10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk3LDEwOV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTQsNDAxLDQ2Miw0NzFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhDaUFnSUNCaWVYUmxZMkpzYjJOcklDSnJhVzVuWkc5dFgyTnZhVzRpSUNKTlFWaGZWRTlMUlU1ZlUxVlFVRXhaSWlBaWEybHVaMlJ2YlY5dVlXMWxJaUFpYTJsdVoxOWhaR1J5WlhOeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJtZGtiMjB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFdHBibWRrYjIwZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU53b2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEUTVNakU0TXpJM0lEQjRZMlptWTJFeE9UQWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVkxhVzVuWkc5dEtITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1Wnl4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZMnhoYVcxT2IyMXBibUYwYVc5dVZHOXJaVzV6S0NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWpjbVZoZEdWTGFXNW5aRzl0WDNKdmRYUmxRRE1nYldGcGJsOWpiR0ZwYlU1dmJXbHVZWFJwYjI1VWIydGxibk5mY205MWRHVkFOQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJtZGtiMjB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFdHBibWRrYjIwZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOc1lXbHRUbTl0YVc1aGRHbHZibFJ2YTJWdWMxOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJtZGtiMjB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80T0FvZ0lDQWdMeThnY0hWaWJHbGpJR05zWVdsdFRtOXRhVzVoZEdsdmJsUnZhMlZ1Y3lncElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJqYkdGcGJVNXZiV2x1WVhScGIyNVViMnRsYm5NS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTNKbFlYUmxTMmx1WjJSdmJWOXliM1YwWlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJtZGtiMjB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TnkwME9Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdOeVpXRjBaVXRwYm1ka2IyMG9DaUFnSUNBdkx5QWdJR3RwYm1ka2IyMU9ZVzFsT2lCaGNtTTBMbE4wY2l3S0lDQWdJQzh2SUNBZ2EybHVaMlJ2YlVSbGMyTnlhWEIwYVc5dU9pQmhjbU0wTGxOMGNpd0tJQ0FnSUM4dklDQWdkRzlyWlc1T1lXMWxPaUJoY21NMExsTjBjaXdLSUNBZ0lDOHZJQ0FnZEc5clpXNVRlVzFpYjJ3NklHRnlZelF1VTNSeUxBb2dJQ0FnTHk4Z0lDQnJhVzVuWkc5dFNXMWhaMlU2SUdGeVl6UXVVM1J5TEFvZ0lDQWdMeThnSUNCcmFXNW5aRzl0VUhKdFlYSjVRMjlzYjNJNklHRnlZelF1VTNSeUxBb2dJQ0FnTHk4Z0lDQnJhVzVuWkc5dFUyVmpiMjVrWVhKNVEyOXNiM0k2SUdGeVl6UXVVM1J5TEFvZ0lDQWdMeThnSUNCcmFXNW5aRzl0UW1GamEyZHliM1Z1WkVOdmJHOXlPaUJoY21NMExsTjBjaXdLSUNBZ0lDOHZJQ0FnYTJsdVoyUnZiVUZqWTJWdWRFTnZiRzl5T2lCaGNtTTBMbE4wY2l3S0lDQWdJQzh2SUNBZ2EybHVaMlJ2YlZSbGVIUkRiMnh2Y2pvZ1lYSmpOQzVUZEhJc0NpQWdJQ0F2THlBZ0lISmxjRzlKWkRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJhVzVuWkc5dEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJMYVc1blpHOXRJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdPQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdPUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNVEFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREV4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmx1WjJSdmJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTNMVFE1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZM0psWVhSbFMybHVaMlJ2YlNnS0lDQWdJQzh2SUNBZ2EybHVaMlJ2YlU1aGJXVTZJR0Z5WXpRdVUzUnlMQW9nSUNBZ0x5OGdJQ0JyYVc1blpHOXRSR1Z6WTNKcGNIUnBiMjQ2SUdGeVl6UXVVM1J5TEFvZ0lDQWdMeThnSUNCMGIydGxiazVoYldVNklHRnlZelF1VTNSeUxBb2dJQ0FnTHk4Z0lDQjBiMnRsYmxONWJXSnZiRG9nWVhKak5DNVRkSElzQ2lBZ0lDQXZMeUFnSUd0cGJtZGtiMjFKYldGblpUb2dZWEpqTkM1VGRISXNDaUFnSUNBdkx5QWdJR3RwYm1ka2IyMVFjbTFoY25sRGIyeHZjam9nWVhKak5DNVRkSElzQ2lBZ0lDQXZMeUFnSUd0cGJtZGtiMjFUWldOdmJtUmhjbmxEYjJ4dmNqb2dZWEpqTkM1VGRISXNDaUFnSUNBdkx5QWdJR3RwYm1ka2IyMUNZV05yWjNKdmRXNWtRMjlzYjNJNklHRnlZelF1VTNSeUxBb2dJQ0FnTHk4Z0lDQnJhVzVuWkc5dFFXTmpaVzUwUTI5c2IzSTZJR0Z5WXpRdVUzUnlMQW9nSUNBZ0x5OGdJQ0JyYVc1blpHOXRWR1Y0ZEVOdmJHOXlPaUJoY21NMExsTjBjaXdLSUNBZ0lDOHZJQ0FnY21Wd2IwbGtPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QXBPaUIyYjJsa0lIc0tJQ0FnSUdOaGJHeHpkV0lnWTNKbFlYUmxTMmx1WjJSdmJRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJhVzVuWkc5dEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJMYVc1blpHOXRJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Rb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmx1WjJSdmJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcExhVzVuWkc5dExtTnlaV0YwWlV0cGJtZGtiMjBvYTJsdVoyUnZiVTVoYldVNklHSjVkR1Z6TENCcmFXNW5aRzl0UkdWelkzSnBjSFJwYjI0NklHSjVkR1Z6TENCMGIydGxiazVoYldVNklHSjVkR1Z6TENCMGIydGxibE41YldKdmJEb2dZbmwwWlhNc0lHdHBibWRrYjIxSmJXRm5aVG9nWW5sMFpYTXNJR3RwYm1ka2IyMVFjbTFoY25sRGIyeHZjam9nWW5sMFpYTXNJR3RwYm1ka2IyMVRaV052Ym1SaGNubERiMnh2Y2pvZ1lubDBaWE1zSUd0cGJtZGtiMjFDWVdOclozSnZkVzVrUTI5c2IzSTZJR0o1ZEdWekxDQnJhVzVuWkc5dFFXTmpaVzUwUTI5c2IzSTZJR0o1ZEdWekxDQnJhVzVuWkc5dFZHVjRkRU52Ykc5eU9pQmllWFJsY3l3Z2NtVndiMGxrT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVXRwYm1ka2IyMDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHVaMlJ2YlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNM0xUUTVDaUFnSUNBdkx5QndkV0pzYVdNZ1kzSmxZWFJsUzJsdVoyUnZiU2dLSUNBZ0lDOHZJQ0FnYTJsdVoyUnZiVTVoYldVNklHRnlZelF1VTNSeUxBb2dJQ0FnTHk4Z0lDQnJhVzVuWkc5dFJHVnpZM0pwY0hScGIyNDZJR0Z5WXpRdVUzUnlMQW9nSUNBZ0x5OGdJQ0IwYjJ0bGJrNWhiV1U2SUdGeVl6UXVVM1J5TEFvZ0lDQWdMeThnSUNCMGIydGxibE41YldKdmJEb2dZWEpqTkM1VGRISXNDaUFnSUNBdkx5QWdJR3RwYm1ka2IyMUpiV0ZuWlRvZ1lYSmpOQzVUZEhJc0NpQWdJQ0F2THlBZ0lHdHBibWRrYjIxUWNtMWhjbmxEYjJ4dmNqb2dZWEpqTkM1VGRISXNDaUFnSUNBdkx5QWdJR3RwYm1ka2IyMVRaV052Ym1SaGNubERiMnh2Y2pvZ1lYSmpOQzVUZEhJc0NpQWdJQ0F2THlBZ0lHdHBibWRrYjIxQ1lXTnJaM0p2ZFc1a1EyOXNiM0k2SUdGeVl6UXVVM1J5TEFvZ0lDQWdMeThnSUNCcmFXNW5aRzl0UVdOalpXNTBRMjlzYjNJNklHRnlZelF1VTNSeUxBb2dJQ0FnTHk4Z0lDQnJhVzVuWkc5dFZHVjRkRU52Ykc5eU9pQmhjbU0wTGxOMGNpd0tJQ0FnSUM4dklDQWdjbVZ3YjBsa09pQjFhVzUwTmpRc0NpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklERXhJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJhVzVuWkc5dEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVUtJQ0FnSUM4dklFMUJXRjlVVDB0RlRsOVRWVkJRVEZrZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJazFCV0Y5VVQwdEZUbDlUVlZCUVRGa2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHVaMlJ2YlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVd0NpQWdJQ0F2THlCMGFHbHpMazFCV0Y5VVQwdEZUbDlUVlZCUVRGa3VkbUZzZFdVZ1BTQXhNREF3TURBd0lDb2dNVEFnS2lvZ05nb2dJQ0FnY0hWemFHbHVkQ0F4TURBd01EQXdNREF3TURBd0lDOHZJREV3TURBd01EQXdNREF3TURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsdVoyUnZiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1Q2lBZ0lDQXZMeUJyYVc1blpHOXRYMjVoYldVZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExsTjBjajRvS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYTJsdVoyUnZiVjl1WVcxbElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJtZGtiMjB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTVFvZ0lDQWdMeThnZEdocGN5NXJhVzVuWkc5dFgyNWhiV1V1ZG1Gc2RXVWdQU0JyYVc1blpHOXRUbUZ0WlFvZ0lDQWdabkpoYldWZlpHbG5JQzB4TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyYVc1blpHOXRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakVLSUNBZ0lDOHZJR3RwYm1ka2IyMWZhVzFoWjJWZmRYSnNJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVUZEhJK0tDa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWEybHVaMlJ2YlY5cGJXRm5aVjkxY213aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsdVoyUnZiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUIwYUdsekxtdHBibWRrYjIxZmFXMWhaMlZmZFhKc0xuWmhiSFZsSUQwZ2EybHVaMlJ2YlVsdFlXZGxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUY0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHVaMlJ2YlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd0NpQWdJQ0F2THlCcmFXNW5YMkZrWkhKbGMzTWdQU0JIYkc5aVlXeFRkR0YwWlR4aGNtTTBMa0ZrWkhKbGMzTStLQ2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbXRwYm1kZllXUmtjbVZ6Y3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyYVc1blpHOXRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJSFJvYVhNdWEybHVaMTloWkdSeVpYTnpMblpoYkhWbElEMGdibVYzSUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cmFXNW5aRzl0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjS0lDQWdJQzh2SUZKRlFVeE5YMEZRVUY5SlJDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pTUlVGTVRWOUJVRkJmU1VRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsdVoyUnZiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUwQ2lBZ0lDQXZMeUIwYUdsekxsSkZRVXhOWDBGUVVGOUpSQzUyWVd4MVpTQTlJSEpsY0c5SlpBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJtZGtiMjB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TXdvZ0lDQWdMeThnYTJsdVoyUnZiVjlrWlhOamNtbHdkR2x2YmlBOUlFZHNiMkpoYkZOMFlYUmxQR0Z5WXpRdVUzUnlQaWdwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbXRwYm1ka2IyMWZaR1Z6WTNKcGNIUnBiMjRpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmx1WjJSdmJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTFDaUFnSUNBdkx5QjBhR2x6TG10cGJtZGtiMjFmWkdWelkzSnBjSFJwYjI0dWRtRnNkV1VnUFNCcmFXNW5aRzl0UkdWelkzSnBjSFJwYjI0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVRBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsdVoyUnZiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkwQ2lBZ0lDQXZMeUJyYVc1blpHOXRYM0J5YVcxaGNubGZZMjlzYjNJZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExsTjBjajRvS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pyYVc1blpHOXRYM0J5YVcxaGNubGZZMjlzYjNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsdVoyUnZiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUyQ2lBZ0lDQXZMeUIwYUdsekxtdHBibWRrYjIxZmNISnBiV0Z5ZVY5amIyeHZjaTUyWVd4MVpTQTlJR3RwYm1ka2IyMVFjbTFoY25sRGIyeHZjZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDJDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwydHBibWRrYjIwdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5Rb2dJQ0FnTHk4Z2EybHVaMlJ2YlY5elpXTnZibVJoY25sZlkyOXNiM0lnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGxOMGNqNG9LUW9nSUNBZ2NIVnphR0o1ZEdWeklDSnJhVzVuWkc5dFgzTmxZMjl1WkdGeWVWOWpiMnh2Y2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyYVc1blpHOXRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJSFJvYVhNdWEybHVaMlJ2YlY5elpXTnZibVJoY25sZlkyOXNiM0l1ZG1Gc2RXVWdQU0JyYVc1blpHOXRVMlZqYjI1a1lYSjVRMjlzYjNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyYVc1blpHOXRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNallLSUNBZ0lDOHZJR3RwYm1ka2IyMWZZbUZqYTJkeWIzVnVaRjlqYjJ4dmNpQTlJRWRzYjJKaGJGTjBZWFJsUEdGeVl6UXVVM1J5UGlncENpQWdJQ0J3ZFhOb1lubDBaWE1nSW10cGJtZGtiMjFmWW1GamEyZHliM1Z1WkY5amIyeHZjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJhVzVuWkc5dEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklIUm9hWE11YTJsdVoyUnZiVjlpWVdOclozSnZkVzVrWDJOdmJHOXlMblpoYkhWbElEMGdhMmx1WjJSdmJVSmhZMnRuY205MWJtUkRiMnh2Y2dvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnRwYm1ka2IyMHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdhMmx1WjJSdmJWOWhZMk5sYm5SZlkyOXNiM0lnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGxOMGNqNG9LUW9nSUNBZ2NIVnphR0o1ZEdWeklDSnJhVzVuWkc5dFgyRmpZMlZ1ZEY5amIyeHZjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJhVzVuWkc5dEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Ua0tJQ0FnSUM4dklIUm9hWE11YTJsdVoyUnZiVjloWTJObGJuUmZZMjlzYjNJdWRtRnNkV1VnUFNCcmFXNW5aRzl0UVdOalpXNTBRMjlzYjNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyYVc1blpHOXRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamdLSUNBZ0lDOHZJR3RwYm1ka2IyMWZkR1Y0ZEY5amIyeHZjaUE5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1VTNSeVBpZ3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltdHBibWRrYjIxZmRHVjRkRjlqYjJ4dmNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cmFXNW5aRzl0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpBS0lDQWdJQzh2SUhSb2FYTXVhMmx1WjJSdmJWOTBaWGgwWDJOdmJHOXlMblpoYkhWbElEMGdhMmx1WjJSdmJWUmxlSFJEYjJ4dmNnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJtZGtiMjB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWdvZ0lDQWdMeThnZEc5MFlXeGZablZ1WkdWa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJblJ2ZEdGc1gyWjFibVJsWkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyYVc1blpHOXRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOaklLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hmWm5WdVpHVmtMblpoYkhWbElEMGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHVaMlJ2YlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjd0xUYzNDaUFnSUNBdkx5QmpiMjV6ZENCamNtVmhkR1ZrUVhOelpYUWdQU0JwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEVOdmJtWnBaeWg3Q2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJPWVcxbE9pQjBhR2x6TG10cGJtZGtiMjFmYm1GdFpTNTJZV3gxWlM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1pHVmphVzFoYkhNNklEWXNDaUFnSUNBdkx5QWdJQ0FnZEc5MFlXdzZJSFJvYVhNdVRVRllYMVJQUzBWT1gxTlZVRkJNV1M1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNCMWJtbDBUbUZ0WlRvZ2RXNXBkRTVoYldVdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa3VZM0psWVhSbFpFRnpjMlYwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHVaMlJ2YlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNUNpQWdJQ0F2THlCcmFXNW5aRzl0WDI1aGJXVWdQU0JIYkc5aVlXeFRkR0YwWlR4aGNtTTBMbE4wY2o0b0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW10cGJtZGtiMjFmYm1GdFpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsdVoyUnZiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN5Q2lBZ0lDQXZMeUJoYzNObGRFNWhiV1U2SUhSb2FYTXVhMmx1WjJSdmJWOXVZVzFsTG5aaGJIVmxMbTVoZEdsMlpTd0tJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsdVoyUnZiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxQ2lBZ0lDQXZMeUJOUVZoZlZFOUxSVTVmVTFWUVVFeFpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpVFVGWVgxUlBTMFZPWDFOVlVGQk1XU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEybHVaMlJ2YlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMUNpQWdJQ0F2THlCMWJtbDBUbUZ0WlRvZ2RXNXBkRTVoYldVdWJtRjBhWFpsTEFvZ0lDQWdabkpoYldWZlpHbG5JQzA0Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlZ1YVhST1lXMWxDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWRzkwWVd3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyYVc1blpHOXRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOek1LSUNBZ0lDOHZJR1JsWTJsdFlXeHpPaUEyTEFvZ0lDQWdjSFZ6YUdsdWRDQTJJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSRVpXTnBiV0ZzY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEU1aGJXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cmFXNW5aRzl0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpBdE56WUtJQ0FnSUM4dklHTnZibk4wSUdOeVpXRjBaV1JCYzNObGRDQTlJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwUTI5dVptbG5LSHNLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRTVoYldVNklIUm9hWE11YTJsdVoyUnZiVjl1WVcxbExuWmhiSFZsTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCa1pXTnBiV0ZzY3pvZ05pd0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJEb2dkR2hwY3k1TlFWaGZWRTlMUlU1ZlUxVlFVRXhaTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUk9ZVzFsT2lCMWJtbDBUbUZ0WlM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0J3ZFhOb2FXNTBJRE1nTHk4Z013b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhMmx1WjJSdmJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3dMVGMzQ2lBZ0lDQXZMeUJqYjI1emRDQmpjbVZoZEdWa1FYTnpaWFFnUFNCcGRIaHVDaUFnSUNBdkx5QWdJQzVoYzNObGRFTnZibVpwWnloN0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhST1lXMWxPaUIwYUdsekxtdHBibWRrYjIxZmJtRnRaUzUyWVd4MVpTNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdaR1ZqYVcxaGJITTZJRFlzQ2lBZ0lDQXZMeUFnSUNBZ2RHOTBZV3c2SUhSb2FYTXVUVUZZWDFSUFMwVk9YMU5WVUZCTVdTNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQjFibWwwVG1GdFpUb2dkVzVwZEU1aGJXVXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2t1WTNKbFlYUmxaRUZ6YzJWMENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnRwYm1ka2IyMHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOd29nSUNBZ0x5OGdMbk4xWW0xcGRDZ3BMbU55WldGMFpXUkJjM05sZEFvZ0lDQWdhWFI0YmlCRGNtVmhkR1ZrUVhOelpYUkpSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwydHBibWRrYjIwdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9Bb2dJQ0FnTHk4Z2EybHVaMlJ2YlY5amIybHVJRDBnUjJ4dlltRnNVM1JoZEdVOFFYTnpaWFErS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW10cGJtZGtiMjFmWTI5cGJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cmFXNW5aRzl0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnprS0lDQWdJQzh2SUhSb2FYTXVhMmx1WjJSdmJWOWpiMmx1TG5aaGJIVmxJRDBnWTNKbFlYUmxaRUZ6YzJWMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cmFXNW5aRzl0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUd0cGJtZGtiMjFmWTI5cGJpQTlJRWRzYjJKaGJGTjBZWFJsUEVGemMyVjBQaWdwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pyYVc1blpHOXRYMk52YVc0aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsdVoyUnZiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUIwYUdsekxtdHBibWRrYjIxZlkyOXBiaTUyWVd4MVpTQTlJSFJvYVhNdVkzSmxZWFJsUzJsdVoyUnZiVlJ2YTJWdUtIUnZhMlZ1VTNsdFltOXNLUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJhVzVuWkc5dEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rdHBibWRrYjIwdVkyeGhhVzFPYjIxcGJtRjBhVzl1Vkc5clpXNXpLQ2tnTFQ0Z2RtOXBaRG9LWTJ4aGFXMU9iMjFwYm1GMGFXOXVWRzlyWlc1ek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJtZGtiMjB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRnS0lDQWdJQzh2SUhSb2FYTXVhWE5RWldGellXNTBLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2FYTlFaV0Z6WVc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsdVoyUnZiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3T0FvZ0lDQWdMeThnZEdocGN5NXBjMUJsWVhOaGJuUW9LUW9nSUNBZ1kyRnNiSE4xWWlCcGMxQmxZWE5oYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyYVc1blpHOXRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEE1Q2lBZ0lDQXZMeUJqYjI1emRDQnpaVzVrWlhJZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsdVoyUnZiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TUFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVkybDBhWHBsYmloelpXNWtaWElwTG1oaGMxWmhiSFZsTENBblQyNXNlU0JqYVhScGVtVnVjeUJqWVc0Z2NHVnlabTl5YlNCMGFHbHpJR0ZqZEdsdmJpY3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJtZGtiMjB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T1FvZ0lDQWdMeThnWTJsMGFYcGxiaUE5SUV4dlkyRnNVM1JoZEdVOFEybDBhWHBsYmxSNWNHVStLQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWlZMmwwYVhwbGJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cmFXNW5aRzl0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFd0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWphWFJwZW1WdUtITmxibVJsY2lrdWFHRnpWbUZzZFdVc0lDZFBibXg1SUdOcGRHbDZaVzV6SUdOaGJpQndaWEptYjNKdElIUm9hWE1nWVdOMGFXOXVKeWtLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZMmwwYVhwbGJuTWdZMkZ1SUhCbGNtWnZjbTBnZEdocGN5QmhZM1JwYjI0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyYVc1blpHOXRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEl3Q2lBZ0lDQXZMeUJqYjI1emRDQnpaVzVrWlhJZ1BTQnVaWGNnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTJsdVoyUnZiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3Q2lBZ0lDQXZMeUJyYVc1blgyRmtaSEpsYzNNZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKcmFXNW5YMkZrWkhKbGMzTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0cGJtZGtiMjB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpFS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtdHBibWRmWVdSa2NtVnpjeTUyWVd4MVpTQTlQVDBnYzJWdVpHVnlMQ0FuVDI1c2VTQjBhR1VnYTJsdVp5QmpZVzRnY0dWeVptOXliU0IwYUdseklHRmpkR2x2YmljcENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2RHaGxJR3RwYm1jZ1kyRnVJSEJsY21admNtMGdkR2hwY3lCaFkzUnBiMjRLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJhVzVuWkc5dEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rdHBibWRrYjIwdWFYTlFaV0Z6WVc1MEtDa2dMVDRnZG05cFpEb0thWE5RWldGellXNTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwydHBibWRrYjIwdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU9Rb2dJQ0FnTHk4Z1kyOXVjM1FnYzJWdVpHVnlJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwydHBibWRrYjIwdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9Bb2dJQ0FnTHk4Z2EybHVaMlJ2YlY5amIybHVJRDBnUjJ4dlltRnNVM1JoZEdVOFFYTnpaWFErS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pyYVc1blpHOXRYMk52YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnRwYm1ka2IyMHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNREFLSUNBZ0lDOHZJR0Z6YzJWeWRDaHpaVzVrWlhJdWFYTlBjSFJsWkVsdUtIUm9hWE11YTJsdVoyUnZiVjlqYjJsdUxuWmhiSFZsS1N3Z0owOXViSGtnWTJsMGFYcGxibk1nWTJGdUlIQmxjbVp2Y20wZ2RHaHBjeUJoWTNScGIyNG5LUW9nSUNBZ1lYTnpaWFJmYUc5c1pHbHVaMTluWlhRZ1FYTnpaWFJDWVd4aGJtTmxDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdOcGRHbDZaVzV6SUdOaGJpQndaWEptYjNKdElIUm9hWE1nWVdOMGFXOXVDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQUFFbUJBeHJhVzVuWkc5dFgyTnZhVzRRVFVGWVgxUlBTMFZPWDFOVlVGQk1XUXhyYVc1blpHOXRYMjVoYldVTWEybHVaMTloWkdSeVpYTnpNUnRCQUZHQ0FnUkpJWU1uQk0vOG9aQTJHZ0NPQWdBT0FBSWlRekVaRkVReEdFU0lBVTRqUXpFWkZFUXhHRVEyR2dFMkdnSTJHZ00yR2dRMkdnVTJHZ1kyR2djMkdnZzJHZ2syR2dvMkdnc1hpQUFOSTBNeEdVRC92ekVZRkVRalE0b0xBQ21CZ0tDVXBZMGRaeXFMOVdlQUVXdHBibWRrYjIxZmFXMWhaMlZmZFhKc2kvbG5LekVBWjRBTVVrVkJURTFmUVZCUVgwbEVpLzluZ0JOcmFXNW5aRzl0WDJSbGMyTnlhWEIwYVc5dWkvWm5nQlZyYVc1blpHOXRYM0J5YVcxaGNubGZZMjlzYjNLTCttZUFGMnRwYm1ka2IyMWZjMlZqYjI1a1lYSjVYMk52Ykc5eWkvdG5nQmhyYVc1blpHOXRYMkpoWTJ0bmNtOTFibVJmWTI5c2IzS0wvR2VBRkd0cGJtZGtiMjFmWVdOalpXNTBYMk52Ykc5eWkvMW5nQkpyYVc1blpHOXRYM1JsZUhSZlkyOXNiM0tML21lQURIUnZkR0ZzWDJaMWJtUmxaQ0puc1NJcVpVUlhBZ0FpS1dWRWkvaFhBZ0N5SmJJaWdRYXlJN0ltZ1FPeUVDS3lBYk8wUENoTEFXY29UR2VKaUFBY2lBQVpNUUFpZ0FkamFYUnBlbVZ1WTBVQlJERUFJaXRsUkJKRWlURUFJaWhsUkhBQVJRRkVpUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
