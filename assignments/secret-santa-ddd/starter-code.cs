// Starter Code for Secret Santa with DDD Assignment

using System;
using System.Collections.Generic;
using System.Linq;

namespace SecretSantaDdd;

// -------------------------
// Domain Layer
// -------------------------

public sealed record ParticipantId(string Value);

public sealed class Participant
{
    public Participant(ParticipantId participantId, string name)
    {
        ParticipantId = participantId;
        Name = name;
    }

    public ParticipantId ParticipantId { get; }
    public string Name { get; }
}

public sealed class ExchangeGroup
{
    private readonly List<Participant> _participants = new();

    public IReadOnlyCollection<Participant> Participants => _participants.AsReadOnly();

    public void AddParticipant(Participant participant)
    {
        // TODO: Prevent duplicate participants by id or name.
        _participants.Add(participant);
    }
}

public sealed class DrawService
{
    public Dictionary<string, string> CreateMatches(IReadOnlyCollection<Participant> participants)
    {
        // TODO: Implement a draw strategy where no one draws themselves.
        // Return a mapping: giverName -> receiverName
        throw new NotImplementedException();
    }
}

// -------------------------
// Application Layer
// -------------------------

public interface IParticipantRepository
{
    IReadOnlyCollection<Participant> ListParticipants();
}

public sealed class InMemoryParticipantRepository : IParticipantRepository
{
    private readonly List<Participant> _participants;

    public InMemoryParticipantRepository(IEnumerable<Participant> participants)
    {
        _participants = participants.ToList();
    }

    public IReadOnlyCollection<Participant> ListParticipants()
    {
        return _participants.AsReadOnly();
    }
}

public sealed class SecretSantaApplicationService
{
    private readonly IParticipantRepository _participantRepository;
    private readonly DrawService _drawService;

    public SecretSantaApplicationService(
        IParticipantRepository participantRepository,
        DrawService drawService)
    {
        _participantRepository = participantRepository;
        _drawService = drawService;
    }

    public Dictionary<string, string> RunDraw()
    {
        var participants = _participantRepository.ListParticipants();
        // TODO: Add validation for minimum participant count.
        return _drawService.CreateMatches(participants);
    }
}

// -------------------------
// Interface / Runner
// -------------------------

public static class Program
{
    public static void Main()
    {
        var participants = new List<Participant>
        {
            new(new ParticipantId("p1"), "Alex"),
            new(new ParticipantId("p2"), "Sam"),
            new(new ParticipantId("p3"), "Riley"),
            new(new ParticipantId("p4"), "Jordan")
        };

        var repository = new InMemoryParticipantRepository(participants);
        var drawService = new DrawService();
        var appService = new SecretSantaApplicationService(repository, drawService);

        var matches = appService.RunDraw();
        foreach (var pair in matches)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}
