using Orleans.Serialization.Buffers;
using Orleans.Serialization.GeneratedCodeHelpers;
using Orleans.Serialization.WireProtocol;

var reader = new Reader<int>();
var field = new Field();

OrleansGeneratedCodeHelper.ReadHeaderExpectingEndBaseOrEndObject(ref reader, ref field, 1);