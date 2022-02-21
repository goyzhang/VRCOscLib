﻿using Newtonsoft.Json;

namespace BuildSoft.VRChat.Osc;

[JsonObject]
public record class OscAvatarParameter
{
#pragma warning disable IDE0044 // Add readonly modifier
    [JsonProperty("name", Required = Required.Always)]
    private string _name = string.Empty;
    [JsonProperty("input", Required = Required.DisallowNull)]
    private OscAvatarParameterInterface? _input;
    [JsonProperty("output", Required = Required.DisallowNull)]
    private OscAvatarParameterInterface? _output;
#pragma warning restore IDE0044 // Add readonly modifier

    public string Name => _name;
    public OscAvatarParameterInterface? Input => _input;
    public OscAvatarParameterInterface? Output => _output;

    private OscAvatarParameter()
    {

    }
    public OscAvatarParameter(string name, OscAvatarParameterInterface? input = null, OscAvatarParameterInterface? output = null)
    {
        _name = name;
        _input = input;
        _output = output;
    }
}
