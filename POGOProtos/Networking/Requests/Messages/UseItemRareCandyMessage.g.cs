// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Requests/Messages/UseItemRareCandyMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/UseItemRareCandyMessage.proto</summary>
  public static partial class UseItemRareCandyMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/UseItemRareCandyMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemRareCandyMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvVXNl",
            "SXRlbVJhcmVDYW5keU1lc3NhZ2UucHJvdG8SJ1BPR09Qcm90b3MuTmV0d29y",
            "a2luZy5SZXF1ZXN0cy5NZXNzYWdlcxomUE9HT1Byb3Rvcy9JbnZlbnRvcnkv",
            "SXRlbS9JdGVtSWQucHJvdG8aIFBPR09Qcm90b3MvRW51bXMvUG9rZW1vbklk",
            "LnByb3RvIn4KF1VzZUl0ZW1SYXJlQ2FuZHlNZXNzYWdlEjIKB2l0ZW1faWQY",
            "ASABKA4yIS5QT0dPUHJvdG9zLkludmVudG9yeS5JdGVtLkl0ZW1JZBIvCgpw",
            "b2tlbW9uX2lkGAIgASgOMhsuUE9HT1Byb3Rvcy5FbnVtcy5Qb2tlbW9uSWRi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor, global::POGOProtos.Enums.PokemonIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.UseItemRareCandyMessage), global::POGOProtos.Networking.Requests.Messages.UseItemRareCandyMessage.Parser, new[]{ "ItemId", "PokemonId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UseItemRareCandyMessage : pb::IMessage<UseItemRareCandyMessage> {
    private static readonly pb::MessageParser<UseItemRareCandyMessage> _parser = new pb::MessageParser<UseItemRareCandyMessage>(() => new UseItemRareCandyMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UseItemRareCandyMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.UseItemRareCandyMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemRareCandyMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemRareCandyMessage(UseItemRareCandyMessage other) : this() {
      itemId_ = other.itemId_;
      pokemonId_ = other.pokemonId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemRareCandyMessage Clone() {
      return new UseItemRareCandyMessage(this);
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 1;
    private global::POGOProtos.Inventory.Item.ItemId itemId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.Item.ItemId ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_id" field.</summary>
    public const int PokemonIdFieldNumber = 2;
    private global::POGOProtos.Enums.PokemonId pokemonId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.PokemonId PokemonId {
      get { return pokemonId_; }
      set {
        pokemonId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UseItemRareCandyMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UseItemRareCandyMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (PokemonId != other.PokemonId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (PokemonId != 0) hash ^= PokemonId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ItemId != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ItemId);
      }
      if (PokemonId != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) PokemonId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemId);
      }
      if (PokemonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PokemonId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UseItemRareCandyMessage other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.PokemonId != 0) {
        PokemonId = other.PokemonId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            itemId_ = (global::POGOProtos.Inventory.Item.ItemId) input.ReadEnum();
            break;
          }
          case 16: {
            pokemonId_ = (global::POGOProtos.Enums.PokemonId) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code